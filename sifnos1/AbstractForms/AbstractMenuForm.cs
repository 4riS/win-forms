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
    //this form serves as a template for the 8 submenus that present the categories the content of the app is organised into
    public partial class AbstractMenuForm: BaseForm
    {
        public AbstractMenuForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenuForm form3 = new MainMenuForm();
            form3.Show(this);
            this.Hide();
        }
    }
}
