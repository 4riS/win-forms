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
    public partial class ProductMenuForm : AbstractMenuForm
    {
        public ProductMenuForm()
        {
            InitializeComponent();
        }

        private void ProductMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("FoodIcons/f-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("FoodIcons/f-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("FoodIcons/f-3.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox7.BackgroundImage = Image.FromFile("FoodIcons/f-4.png");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BackColor = System.Drawing.Color.Transparent;

            remember("Mastelo", 1);
            remember("Amugdalota", 2);
            remember("Rebuthada", 3);
            remember("Melopitha", 4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Mastelo Mastelo = new Mastelo();
            Mastelo.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Amugdalota Amugdalota = new Amugdalota();
            Amugdalota.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Rebuthada Rebuthada = new Rebuthada();
            Rebuthada.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Melopitha Melopitha = new Melopitha();
            Melopitha.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HikingMenuForm HikingMenuForm = new HikingMenuForm();
            HikingMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityMenuForm ActivityMenuForm = new ActivityMenuForm();
            ActivityMenuForm.Show();
            this.Hide();
        }
    }
}
