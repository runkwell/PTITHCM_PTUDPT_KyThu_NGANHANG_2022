using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_DDHchuacoPN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DDHchuacoPN()
        {
            InitializeComponent();
        }
        public Xrpt_DDHchuacoPN(String macn)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = macn;
        }
    }
}
