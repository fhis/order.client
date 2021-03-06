package iih.ci.ord.cfg.cirulecfg.s;
import xap.mw.core.annotation.Service;
import xap.mw.core.service.constant.Binding;
import xap.sys.appfw.orm.desc.DescManager;
import xap.sys.appfw.orm.utils.IAppFwTempTbl;
import xap.sys.appfw.orm.handle.dataobject.paging.PaginationInfo;
import xap.sys.appfw.orm.handle.dataobject.paging.PagingRtnData;
import xap.sys.appfw.orm.handle.dataobject.BaseDOService;
import iih.ci.ord.cfg.cirulecfg.d.desc.CiRuleCfgRelRuleDesc;
import iih.ci.ord.cfg.cirulecfg.d.CiRuleCfgRelRule;
import iih.ci.ord.cfg.cirulecfg.i.ICiRuleCfgRelRuleCudService;
import iih.ci.ord.cfg.cirulecfg.i.ICiRuleCfgRelRuleRService;
import xap.sys.permfw.pub.BDReferenceChecker;
import xap.sys.appfw.bizrule.validation.Validator;

/**
 * 医嘱规则配置主实体CRUD服务实现
 */
@Service(serviceInterfaces={ICiRuleCfgRelRuleCudService.class,ICiRuleCfgRelRuleRService.class}, binding=Binding.JSONRPC)
public class CiRuleCfgRelRuleCrudServiceImpl extends BaseDOService<CiRuleCfgRelRule> implements ICiRuleCfgRelRuleCudService,ICiRuleCfgRelRuleRService {

    public CiRuleCfgRelRuleCrudServiceImpl() {
        super(DescManager.getInstance().getDODesc(CiRuleCfgRelRuleDesc.class),IAppFwTempTbl.tmp_iaw_05.name()); 
    }
    
    @Override
	protected Validator[] getDeleteValidator() {
		return new Validator[] {
				BDReferenceChecker.getInstance()
		};
	}
}

