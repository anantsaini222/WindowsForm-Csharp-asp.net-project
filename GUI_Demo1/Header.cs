using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Demo1
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
          
        }

        private void Header_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}
