package iih.ci.ord.s.bp.impt;

import org.apache.commons.lang3.ArrayUtils;

import iih.bd.srv.diagcate.d.DiCateItemDO;
import iih.bd.srv.ortpl.d.OrTmplCaDO;
import iih.bd.srv.ortpl.i.IOrtmplcaCudService;
import xap.mw.core.data.BizException;
import xap.mw.sf.core.util.ServiceFinder;
import xap.sys.init.impt.BaseDataImport;
import xap.sys.init.impt.IDataImport;
import xap.sys.jdbc.facade.DAFacade;

public class OrTmplCaImportServiceImpl extends BaseDataImport<OrTmplCaDO> implements IDataImport {

	@Override
	public boolean checkNotNull() throws BizException {
		// 1、从导入临时库得到需要导入目标库的数据,此数据是数据源为 import 的库获得
		OrTmplCaDO[] dos = getDOsFromImportDB(new OrTmplCaDO(),"1=1",false);
    	if (ArrayUtils.isEmpty(dos))
    		throw new BizException("医嘱模板分类导入数据为空！");
    	
		// 2、名称编码校验
		//checkNullValue(Arrays.asList(OrTplNItmDO.NAME, OrTplNItmDO.CODE), dos);
    	
		return true;
	}
	
	@Override
	public boolean importData() throws BizException {
		// 1、从导入临时库得到需要导入目标库的数据,此数据是数据源为 import 的库获得
		OrTmplCaDO[] dos = getDOsFromImportDB(new OrTmplCaDO(),"1=1",true);
    	if (ArrayUtils.isEmpty(dos))
    		throw new BizException("医嘱模板分类导入数据为空！");
    	
		// 3、状态改为New
		processDOs(dos);

		// 4、调用框架的新增方法(其中包括管控唯一性校验等)插入目标库
		ServiceFinder.find(IOrtmplcaCudService.class).insert(dos);

		return true;
	}
	
	@Override
	public boolean cleanData() throws BizException {
		DAFacade daFacade = new DAFacade();
		daFacade.execUpdate("delete from "+new OrTmplCaDO().getTableName()+""+ " where "+new OrTmplCaDO().getPKFieldName() +" not like '@@@@%'");
		return true;
	}

	@Override
	public String[] getImportTable() throws BizException {
		return new String[]{new OrTmplCaDO().getTableName()};
	}
}
