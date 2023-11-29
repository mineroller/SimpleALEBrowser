using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_ALE_Browser
{
    public partial class frmAuditResultDetails : Form
    {
        public frmAuditResultDetails()
        {
            InitializeComponent();
        }

        public frmAuditResultDetails(UserAuditResult _uar)
        {
            InitializeComponent();

            lblActionDateLocal.Text = _uar.ActionDateLocal;
            lblComputerName.Text = _uar.ComputerName;
            lblObjectName.Text = _uar.ObjectName;  
            lblUserName.Text = _uar.UserName; 
            txtInformation.Text = _uar.Information;
            lblActionId.Text = _uar.ActionId.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
