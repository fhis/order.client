package iih.ci.ord.s.ems.biz.op.tmpl.gj.ortmpl.ris;

import iih.ci.ord.ems.d.CiEnContextDTO;
import iih.ci.ord.s.ems.biz.meta.ErrorEmsList;
import iih.ci.ord.s.ems.biz.op.tmpl.base.ris.TmplBaseRisValidate;
import xap.mw.core.data.BizException;
import xap.mw.core.data.FArrayList;

/**
 * 检查医疗单有效性检查
 * @author wangqingzhu
 *
 */
public class TmplRisValidate extends TmplBaseRisValidate {

	public ErrorEmsList viewModelValidate(Object objEms,CiEnContextDTO ctx) throws BizException  {
		
		ErrorEmsList errorlist=new ErrorEmsList();
		
		return errorlist;
	}

	public ErrorEmsList beforeSaveValidate(Object objEms) throws BizException {
		return null;
	}
}
