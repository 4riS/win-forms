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
    //this form is the menu of the Activities category. It presents the user to the different activities he can enjoy in Sifnos
    public partial class ActivityMenuForm : AbstractMenuForm
    {
        public ActivityMenuForm()
        {
            InitializeComponent();
        }

        private void ActivityMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("FestIcons/f-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("FestIcons/f-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;

            remember("Tselementes", 1);
            remember("Panhgyria", 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Tselementes Tselementes = new Tselementes();
            Tselementes.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Panhgyria Panhgyria = new Panhgyria();
            Panhgyria.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BarMenuForm BarMenuForm = new BarMenuForm();
            BarMenuForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductMenuForm ProductMenuForm = new ProductMenuForm();
            ProductMenuForm.Show();
            this.Hide();
        }
    }
}
