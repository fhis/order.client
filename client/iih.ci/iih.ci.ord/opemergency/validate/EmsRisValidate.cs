﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iih.ci.ord.ciordems.d;
using iih.ci.ord.opemergency.ems;
using iih.ci.ord.opemergency.ems.common;
using iih.ci.ord.opemergency.ems.dp;
using xap.rui.control.extentions;

namespace iih.ci.ord.opemergency.validate
{
    /// <summary>
    /// <para>描    述 :  检查医疗单有效性检查    			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.validate    </para>    
    /// <para>类 名 称 :  EmsRisValidate					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  qzwang         				</para> 
    /// <para>修 改 人 :  qzwang         				</para> 
    /// <para>创建时间 :  2016/7/12 13:31:48             </para>
    /// <para>更新时间 :  2016/7/12 13:31:48             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2016. All rights reserved.</para> 
    /// </summary>
    class EmsRisValidate : BaseEmsValidate
    {
        public override bool OrdValivate(object model, BaseEmsView sender)
        {
            base.OrdValivate(model, sender);

            EmsObsItemDO emsApObs = (model as EmsRisViewModel).GetFormDataSource() as EmsObsItemDO;

            if (emsApObs.Fg_set==true )
            {
                bool fg_check = false;
                foreach (EmsObsLap obsLap in emsApObs.EmsOrObsList)
                {
                    if (obsLap.Fg_chk == true)
                    {
                        fg_check = true;
                        break;
					} 
                    
                }
                if (!fg_check) sender.OrdErrorList.Add("检查明细项目不能为空");
                
            }
            //DateTime tToday = CommonExtentions.NowTime(this);

            //tToday -= TimeSpan.FromSeconds(tToday.Second);
            //if (emsApObs.Dt_plan < tToday)
            //{
            //    sender.OrdErrorList.Add("计划检查时间不能在当前时间之前！");
            //}
            return (sender.OrdErrorList.Count == 0);
        }
    }
}
