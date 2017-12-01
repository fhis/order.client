﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xap.rui.engine;
using xap.rui.engine.statehandlers;
using xap.rui.engine.xactions;

namespace iih.ci.ord.opemergency.action.statehandler
{
    /// <summary>
    /// <para>描    述 :                     			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.action.statehandler    </para>    
    /// <para>类 名 称 :  Class1					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  vivi         				</para> 
    /// <para>修 改 人 :  vivi         				</para> 
    /// <para>创建时间 :  10/21/2016 4:15:19 PM             </para>
    /// <para>更新时间 :  10/21/2016 4:15:19 PM             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2016. All rights reserved.</para> 
    /// </summary>
    public class OpHpTransformEnFileStateHandler : IXStateHandler
    {
        public void HandleState(object sender, string oldState, string uiEvent, string newState, Dictionary<string, object> data, BaseContext baseContext)
        {
            var action = sender as XBroadcastAction;
            switch (uiEvent) {
                case UIEvent.LOAD:
                    action.Enabled = false;
                    break;

                case "ListSelected":
                    action.Enabled = true;
                    break;


                default:
                    break;
            }
        }
    }
}
