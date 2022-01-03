using Aucotec.EngineeringBase.Client.Runtime;
using System;
using System.AddIn;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAM_EB_WorksheetAttr
{
    /// <summary>
    /// Implements Wizard FAM_EB_WS_Attr
    /// </summary>
    [AddIn("FAM_EB_WS_Attr", Description = "", Publisher = "TKE")]
    public class MyPlugIn : PlugInWizard
    {
        /// <summary>
        /// Runs the wizard.
        /// </summary>
        /// <param name="myApplication">Application object instance</param>	
        public override void Run(Application myApplication)
        {
            // System.Diagnostics.Debug.WriteLine("Hello World!");
        }
    }
}
