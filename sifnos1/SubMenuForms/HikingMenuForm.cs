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
    public partial class HikingMenuForm : AbstractMenuForm
    {
        public HikingMenuForm()
        {
            InitializeComponent();
        }

        private void HikingMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("HikIcons/h-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("HikIcons/h-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("HikIcons/h-3.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;

            remember("AndreasArtemonas", 1);
            remember("AppVathy", 2);
            remember("KamKapsalos", 3);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            AndreasArtemonas AndreasArtemonas = new AndreasArtemonas();
            AndreasArtemonas.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AppVathy AppVathy = new AppVathy();
            AppVathy.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            KamKapsalos KamKapsalos = new KamKapsalos();
            KamKapsalos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelMenuForm HotelMenuForm = new HotelMenuForm();
            HotelMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductMenuForm ProductMenuForm = new ProductMenuForm();
            ProductMenuForm.Show();
            this.Hide();
        }
    }
}
