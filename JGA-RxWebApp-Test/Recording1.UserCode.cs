﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace JGA_RxWebApp_Test
{
    public partial class Recording1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo spantagInfo, RepoItemInfo divtagInfo, RepoItemInfo divtagInfo1)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
            spantagInfo.FindAdapter<SpanTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'divtagInfo' at 220;11.", divtagInfo);
            divtagInfo.FindAdapter<DivTag>().Click("220;11");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'divtagInfo' at Center.", divtagInfo);
            divtagInfo.FindAdapter<DivTag>().MoveTo();
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'divtagInfo' at 141;22.", divtagInfo);
            divtagInfo.FindAdapter<DivTag>().MoveTo("141;22");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'divtagInfo1' at 816;380.", divtagInfo1);
            divtagInfo1.FindAdapter<DivTag>().MoveTo("816;380");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'divtagInfo1' at 798;350.", divtagInfo1);
            divtagInfo1.FindAdapter<DivTag>().MoveTo("798;350");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }

    }
}
