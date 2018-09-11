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

    // this form serves as a template for the forms presenting content to the user
   

    public  partial class ContentForm: BaseForm
    {
        public ContentForm()
        {
            InitializeComponent();
        }

        private void ContentForm_Load(object sender, EventArgs e)
        {
            if (LogInForm.current_user_id == "guest")
            {
                button10.Hide();      //hides the slideshow button from the guests. Only registered users can use the slideshow service
                button4.Hide();
            } else
            {
                button10.Show();
                button4.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
