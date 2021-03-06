package iih.ci.ord.s.ems.biz.op.base.bp;

import xap.mw.core.data.BizException;
import iih.ci.ord.d.ems.di.DiagRstDTO;
import iih.ci.ord.d.ems.di.DiagSaveDTO;
import iih.ci.ord.s.ems.biz.itf.bp.IDiagSignBP;

/**
 * 诊断签署逻辑基类
 * @author wangqingzhu
 *
 */
public class DiagBaseSignBP extends DiagBaseSaveBP implements IDiagSignBP {

	@Override
	public DiagRstDTO save(DiagSaveDTO diSaveInfo) throws BizException {
		// TODO Auto-generated method stub
		return super.save(diSaveInfo);
	}

	@Override
	public DiagRstDTO sign(DiagSaveDTO diSignInfo) throws BizException {
		// TODO Auto-generated method stub
		return this.save(diSignInfo);
	}

}
