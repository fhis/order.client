package iih.ci.ord.s.bp.ems_v1;

import iih.ci.ord.ciordems.d.EmsDrugItemDO;
import iih.ci.ord.ciorder.d.CiOrderDO;
import iih.ci.ord.ems.d.CiEnContextDTO;
import xap.mw.core.data.BizException;
import xap.mw.core.data.FMap2;

/**
 * 通用医嘱医疗单
 * @author wangqzh
 *
 */
public class EmsCommItemBP extends EmsBaseItemBP {

	public EmsCommItemBP(CiEnContextDTO ctx) {
		super(ctx);
		// TODO Auto-generated constructor stub
	}

	@Override
	public FMap2 getViewModel(CiOrderDO ord) throws BizException{
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public CiOrderDO save(EmsDrugItemDO vm)throws BizException {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public FMap2 getViewModel(String id_srv, String id_mm) throws BizException {
		// TODO Auto-generated method stub
		return null;
	}

}
