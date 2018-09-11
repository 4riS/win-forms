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
    public partial class BarMenuForm : AbstractMenuForm
    {
        public BarMenuForm()
        {
            InitializeComponent();
        }

        private void BarMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("BarIcons/bar-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("BarIcons/bar-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;

            remember("ToDoloma", 1);
            remember("Folie", 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ToDoloma ToDoloma = new ToDoloma();
            ToDoloma.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Folie Folie = new Folie();
            Folie.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityMenuForm ActivityMenuForm = new ActivityMenuForm();
            ActivityMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurantsMenuForm RestaurantsMenuForm = new RestaurantsMenuForm();
            RestaurantsMenuForm.Show();
            this.Hide();
        }
    }
}
