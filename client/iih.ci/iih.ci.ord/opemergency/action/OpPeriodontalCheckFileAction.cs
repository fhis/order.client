﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xap.rui.engine.xactions;

namespace iih.ci.ord.opemergency.action
{
    /// <summary>
    /// <para>描    述 :   牙周组织检查表                  			</para>
    /// <para>说    明 :                     			</para>
    /// <para>项目名称 :  iih.ci.ord.opemergency.action    </para>    
    /// <para>类 名 称 :  Class1					</para> 
    /// <para>版 本 号 :  v1.0.0.0           			</para> 
    /// <para>作    者 :  qzwang         				</para> 
    /// <para>修 改 人 :  qzwang         				</para> 
    /// <para>创建时间 :  9/29/2016 8:25:43 PM             </para>
    /// <para>更新时间 :  9/29/2016 8:25:43 PM             </para> 
    /// <para>Copyright @ 北大医信（IIH项目组） 2016. All rights reserved.</para> 
    /// </summary>
    public class OpPeriodontalCheckFileAction : XBroadcastAction
    {
        public OpPeriodontalCheckFileAction()
            : base("PeriodontalCheckFile", "PeriodontalCheckFile", Keys.None, "牙周组织检查表", "牙周组织检查表")
        { }
    }
}
