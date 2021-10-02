using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Demo1
{
    public partial class WelcomeForm : Form
    {
        Form1 f1;
        LoginForm f2;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 != null)
            {
                f2.Hide();
            }
            f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void logInFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 != null)
            {
                f1.Hide();
            }
            f2 = new LoginForm();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
