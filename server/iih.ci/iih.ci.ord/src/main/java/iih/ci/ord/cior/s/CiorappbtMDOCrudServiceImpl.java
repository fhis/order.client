package iih.ci.ord.cior.s;
import xap.mw.core.annotation.Service;
import xap.mw.core.service.constant.Binding;
import xap.sys.appfw.orm.desc.DescManager;
import xap.sys.appfw.orm.utils.IAppFwTempTbl;
import xap.sys.appfw.orm.handle.dataobject.paging.PaginationInfo;
import xap.sys.appfw.orm.handle.dataobject.paging.PagingRtnData;
import xap.sys.appfw.orm.handle.dataobject.BaseDOService;
import iih.ci.ord.cior.d.desc.OrdApBtDODesc;
import iih.ci.ord.cior.d.OrdApBtDO;
import iih.ci.ord.cior.i.ICiorappbtMDOCudService;
import iih.ci.ord.cior.i.ICiorappbtMDORService;
import xap.sys.permfw.pub.BDReferenceChecker;
import xap.sys.appfw.bizrule.validation.Validator;

/**
 * 备血申请单主实体CRUD服务实现
 */
@Service(serviceInterfaces={ICiorappbtMDOCudService.class,ICiorappbtMDORService.class}, binding=Binding.JSONRPC)
public class CiorappbtMDOCrudServiceImpl extends BaseDOService<OrdApBtDO> implements ICiorappbtMDOCudService,ICiorappbtMDORService {

    public CiorappbtMDOCrudServiceImpl() {
        super(DescManager.getInstance().getDODesc(OrdApBtDODesc.class),IAppFwTempTbl.tmp_iaw_14.name()); 
    }
    
    @Override
	protected Validator[] getDeleteValidator() {
		return new Validator[] {
				BDReferenceChecker.getInstance()
		};
	}
}

