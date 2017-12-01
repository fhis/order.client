package iih.ci.ord.s.ems.biz.op.tmpl.std.ortmpl.opr;

import iih.ci.ord.ems.d.CiEnContextDTO;
import iih.ci.ord.s.ems.biz.meta.ErrorEmsList;
import iih.ci.ord.s.ems.biz.op.tmpl.base.opr.TmplBaseOprValidate;
import xap.mw.core.data.BizException;
import xap.mw.core.data.FArrayList;

/**
 * 手术医疗单有效性检查
 * @author wangqingzhu
 *
 */
public class TmplOprValidate extends TmplBaseOprValidate {
	public ErrorEmsList viewModelValidate(Object objEms,CiEnContextDTO ctx) throws BizException  {
		ErrorEmsList errorlist=new ErrorEmsList();
		
		return errorlist;
	}

	public ErrorEmsList beforeSaveValidate(Object objEms) throws BizException {
		return null;
	}
}
