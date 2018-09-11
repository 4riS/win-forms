using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifnos1
{
    public partial class AboutUs : BaseForm
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            label100.BackColor = System.Drawing.Color.Transparent;
            label111.BackColor = System.Drawing.Color.Transparent;
            label122.BackColor = System.Drawing.Color.Transparent;
            label144.BackColor = System.Drawing.Color.Transparent;
        }

        private void button155_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
