using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        localhost.MathServiceClient ms = new localhost.MathServiceClient();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = ms.add(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
            txtResult.Text = result.ToString();

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int result = ms.sub(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
            txtResult.Text = result.ToString();
        }
    }
}
