﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xap.rui.engine.xactions;
using iih.ci.ord.opemergency.action.costant;
using System.Windows.Forms;

namespace iih.ci.ord.opemergency.action
{
    /// <summary>
    /// <para>描    述 :                     			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.action    </para>    
    /// <para>类 名 称 :  OpCurrOrderCancelAction					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  Administrator         				</para> 
    /// <para>修 改 人 :  Administrator         				</para> 
    /// <para>创建时间 :  2017/8/21 10:39:12             </para>
    /// <para>更新时间 :  2017/8/21 10:39:12             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2017. All rights reserved.</para> 
    /// </summary>
    public class OpCurrOrderCancelAction : XBroadcastAction
    {
        public OpCurrOrderCancelAction()
            : base(OpActionConstant.OpCurrOrderCancelAction, OpActionConstant.OpCurrOrderCancelAction, Keys.None, "作废当前医嘱", "取消提交")
        { }
    }
}
