using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.vendor
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            uC_AddOrder.Visible = true;
            uC_AddOrder.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddOrder.Visible=true;
        }
    }
}
