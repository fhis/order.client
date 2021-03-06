﻿
using System;
using iih.ci.ord.opemergency.operateaction.baseoperate;
using iih.ci.ord.opemergency.operateaction.dto;
using iih.ci.ord.opemergency.action.costant;
using System.Collections.Generic;

namespace iih.ci.ord.opemergency.operateaction.opcomplete.view
{
    /// <summary>
    /// <para>描    述 :  诊毕、撤回触发校验诊断	</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.operateaction.opcomplete.view    </para>    
    /// <para>类 名 称 :  CiDiCompleteCheckAction					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  Young         				</para> 
    /// <para>修 改 人 :  Young         				</para> 
    /// <para>创建时间 :  2017/10/31 14:54:45             </para>
    /// <para>更新时间 :  2017/10/31 14:54:45             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2017. All rights reserved.</para> 
    /// </summary>
    public class CiDiCompleteCheckAction : AbstractActionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        protected override void DoSendAction(RequestParam request, ResponseParam response)
        {
            this.FireBizEventSent(this, OpActionConstant.OP_COMPLETE_DI_SEND_ACTION, OpActionConstant.OP_COMPLETE_DI_RECEIVE_ACTION, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataDic"></param>
        public override void ReceiveBizEvent(Dictionary<string, object> dataDic)
        {
            if (dataDic.ContainsKey(OpActionConstant.OP_COMPLETE_DI_RECEIVE_ACTION))
            {
                this.DoReceiveAction(this.request, this.response);
            }
        }
    }
}
