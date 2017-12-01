package iih.ci.ord.content.d;

import java.util.ArrayList;
import java.util.List;

import com.mysql.jdbc.StringUtils;

import xap.mw.core.data.BizException;
import xap.mw.core.data.DOStatus;
import xap.mw.core.data.FArrayList;
import xap.mw.sf.core.util.ServiceFinder;
import xap.sys.xbd.udi.d.UdidocDO;
import xap.sys.xbd.udi.i.IUdidocServiceExt;
import iih.bd.bc.udi.pub.IBdSrvDictCodeTypeConst;
import iih.ci.ord.cior.d.OrdApLabDO;
import iih.ci.ord.ciordems.d.EmsType;
import iih.ci.ord.ems.d.CiEmsDTO;
import iih.ci.ord.ems.d.CiEmsSrvDTO;

/**
 * 医嘱内容生成通用检验生成工厂（非皮试类）
 */
public class DefaultLisOrContentFactory implements CiOrContentObjFactory {

	private String ismuldose;
	private String ismulexec;
	
	@Override
	public CiOrContentDO create(CiEmsDTO ems) throws BizException {
		if (ems == null || ems.getEmssrvs() == null || ems.getEmssrvs().size() == 0) {
			return getNullContent(ems);
		}
		CiOrContentDO contentdo = new CiOrContentDO();
		String sd_srvtp = ((CiEmsSrvDTO) ems.getEmssrvs().get(0)).getSd_srvtp();
		if (sd_srvtp != null && sd_srvtp != "") {
			contentdo.setTypeId(sd_srvtp);
		} else {
			contentdo.setTypeId(ICiOrContentConst.ORContent_TYPE_DEFAULT);
		}
		List<String> lst = GetSrvExecDose.exec(ems.getId_srv());
		ismuldose = lst.get(0);
		ismulexec = lst.get(1);
		contentdo.setTitle(getTitle(ems));
		contentdo.setItemInfos(getItemInfos(ems));
		contentdo.setTailInfo(getTailInfos(ems));
		return contentdo;
	}

	/**
	 * 获得标题数据
	 * 
	 * @param ems
	 * @return
	 */
	private String getTitle(CiEmsDTO ems) {
		return "";
	}

	/**
	 * 获得表体数据
	 * 
	 * @param ems
	 * @return
	 * @throws BizException 
	 */
	private ArrayList<ArrayList<String>> getItemInfos(CiEmsDTO ems) throws BizException {
		if (ems == null || ems.getEmssrvs() == null)
			return null;
		ArrayList<ArrayList<String>> list = new ArrayList<ArrayList<String>>();
		ArrayList<String> arrList = new ArrayList<String>();
		FArrayList emssrvs = ems.getEmssrvs();
		for (int i = 0; i < emssrvs.size(); i++) {
			CiEmsSrvDTO item = (CiEmsSrvDTO) emssrvs.get(i);
			if (item.getStatus() == DOStatus.DELETED || item.getFg_or() == null || !item.getFg_or().booleanValue())
				continue;
			OrdApLabDO labDO = (OrdApLabDO) ems.getOrapplysheet().get(EmsType.LIS + "");
			if (labDO != null && !StringUtils.isNullOrEmpty(labDO.getSd_samptp())) {
				IUdidocServiceExt udidocServiceExt = ServiceFinder.find(IUdidocServiceExt.class);
				UdidocDO[] udiDOs = udidocServiceExt.findByUdidoclistCode(IBdSrvDictCodeTypeConst.SD_SAMPTP);
				String strName = "";
				if (udiDOs != null) {
					for (UdidocDO udiDO : udiDOs) {
						if (udiDO.getCode().equals(labDO.getSd_samptp())) {
							strName = udiDO.getName();
						}
					}
				}
				arrList.add(item.getName_srv()
						+ (StringUtils.isNullOrEmpty(strName) ? "" : "(" + strName + ")"));
			} else {
				arrList.add(item.getName_srv());
			}
		}
		
		if (ismuldose != null && ismuldose.equals("Y")) {
			arrList.add((ems.getQuan_medu() == null) ? "" : ems.getQuan_medu().toString());
			arrList.add((ems.getName_unit_med() == null) ? "" : ems.getName_unit_med());
		}
		
		list.add(arrList);
		return list;
	}

	/**
	 * 获得表尾数据
	 * 
	 * @param ems
	 * @return
	 */
	private ArrayList<String> getTailInfos(CiEmsDTO ems) {
		ArrayList<String> list = new ArrayList<String>();
		String str = "";
		if (ismulexec != null && ismulexec.equals("Y")) {
			str += ((ems.getName_freq() == null) ? "" : ems.getName_freq().toString())
					+ ((ems.getDays_or() == null) ? "" : "   " + ems.getDays_or().toString() + "天");
		}
		
		if (ems.getFg_urgent() != null && ems.getFg_urgent().booleanValue()) {
			if (str.length() > 0)
				str += "   ";
			str += "加急！";
		}
		if (ems.getNote() != null && !"".equals(ems.getNote())) {
			str += ICiOrContentConst.ChangeToEscapeCharacter(ems.getNote());
		}
		if (str.length() > 0) {
			list.add(str);
		}
		return list;
	}

	/**
	 * 获得空医嘱内容
	 * 
	 * @param ems
	 */
	private CiOrContentDO getNullContent(CiEmsDTO ems) {
		NullOrContentFactory nullfact = new NullOrContentFactory();
		return nullfact.create(ems);
	}
}
