using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_DSNV : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSNV()
        {
            InitializeComponent();
        }
        public Xrpt_DSNV(string macn)
        {
            InitializeComponent();
            //this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = macn;

            //lblTime.Text = DateTime.Now.ToString();
            //this.sqlDataSource1.Fill();
        }
    }
}
