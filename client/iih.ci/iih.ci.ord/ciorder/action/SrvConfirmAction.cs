﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xap.rui.engine.xactions;
using xap.rui.engine;
using System.Windows.Forms;

namespace iih.ci.ord.ciorder.action
{
   public class SrvConfirmAction : XBroadcastAction
    {

       public SrvConfirmAction()
           : base("Srvfirm", "Srvfirm", Keys.None, "补费",
                       "补费"
                       )
            {
            }
    }
}
