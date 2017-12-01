﻿
using iih.ci.ord.dto.emsmain;

namespace iih.ci.ord.opemergency.orderaction
{
    /// <summary>
    /// <para>描    述 :  医嘱操作-撤回     			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.orderaction    </para>    
    /// <para>类 名 称 :  OrderRevertAction					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  Young         				</para> 
    /// <para>修 改 人 :  Young         				</para> 
    /// <para>创建时间 :  2017/8/11 17:39:40             </para>
    /// <para>更新时间 :  2017/8/11 17:39:40             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2017. All rights reserved.</para> 
    /// </summary>
    public class OrderRevertAction : OrderAction
    {
        public override OrderRstDTO[] exec(OrderOperateDTO[] args, bool isSeries = false)
        {
            return new OrderRstDTO[] { this.ciOrderMainService.revert(args[0]) };
        }
    }
}
