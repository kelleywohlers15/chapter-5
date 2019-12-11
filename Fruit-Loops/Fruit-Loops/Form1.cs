using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Loops
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int numGreeting = Convert.ToInt32(txtgreeting.Text);
            for (int i = 0; i < numGreeting; ++i)
            {
                lblResult.Text += "Hello\n";
            }
        }
    }
}
