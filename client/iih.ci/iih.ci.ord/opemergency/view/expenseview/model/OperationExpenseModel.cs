﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xap.rui.appfw;
using iih.ci.ord.ciorder.d;
using xap.mw.core.data;
using iih.ci.ord.ciordems.d;
using iih.ci.ord.ordsrvmm.d;
using iih.ci.ord.emsdi.d;
using iih.ci.ord.ciorder.viewmodel.impext;

namespace iih.ci.ord.opemergency.view.expenseview.model
{
    /// <summary>
    /// <para>描    述 :  手术费用模型        			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.view.expenseview.model    </para>    
    /// <para>类 名 称 :  OperationExpenseModel					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  qzwang         				</para> 
    /// <para>修 改 人 :  qzwang         				</para> 
    /// <para>创建时间 :  2016/7/12 13:34:46             </para>
    /// <para>更新时间 :  2016/7/12 13:34:46             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2016. All rights reserved.</para> 
    /// </summary>
    public class OperationExpenseModel : ExpenseModel
    {
        public OperationExpenseModel(XapDataList<EmsOrDrug> ds)
            : base(ds)
        {

        }
        protected override ciordems.d.EmsOrDrug[] Convert2Drugs(iih.ci.ord.dto.d.CiOrAggAndRelInfo info, object viewModel)
        {
            if (viewModel == null || !(viewModel is XapDataList<EmsOpitemDO>))
            {
                return null;
            }
            XapDataList<EmsOpitemDO> drugList = viewModel as XapDataList<EmsOpitemDO>;
            
            CiOrderDO ord = info.OrAggDO.getParentDO();

            FMap orSrvMmMap = info.OrSrvMmMap;
           

            List<EmsOrDrug> szDrugs = new List<EmsOrDrug>();
            Dictionary<String, object> tmpCacheSrv = new Dictionary<string, object>();

            // 处理医嘱带过来的信息
            EmsOpitemDO opItemDO = null;
            if (drugList.Count > 0)
            {
                opItemDO = drugList[0];
                tmpCacheSrv.Add(opItemDO.Id_srv, opItemDO);
            }

            // 处理附加项
            szDrugs.AddRange(ToEmsOrDrugs(info.OrAggDO, tmpCacheSrv, info.OrSrvMmMap, info.BlSrvMap));

            return szDrugs.ToArray();
        }

        protected override String GetOrdDeptMp()
        {
            XapDataList<EmsOpitemDO> viewDatasource = this.GetEmsViewModel() as XapDataList<EmsOpitemDO>;
            string id_dep_flow = "";
            if (viewDatasource != null && viewDatasource.Count > 0) {
                id_dep_flow = viewDatasource[0].Id_mp_dep;
            }
            return id_dep_flow;
        }
     
    }
}
