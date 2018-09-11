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
    public partial class HotelMenuForm : AbstractMenuForm
    {
        public HotelMenuForm()
        {
            InitializeComponent();
        }

        private void HotelMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("HotelIcons/f-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("HotelIcons/f-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("HotelIcons/f-3.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox7.BackgroundImage = Image.FromFile("HotelIcons/f-4.png");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BackColor = System.Drawing.Color.Transparent;

            remember("cycladesHotel", 1);
            remember("Elies", 2);
            remember("Verina", 3);
            remember("Nirides", 4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cycladesHotel cycladesHotel = new cycladesHotel();
            cycladesHotel.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Elies Elies = new Elies();
            Elies.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Verina Verina = new Verina();
            Verina.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Nirides Nirides = new Nirides();
            Nirides.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeachMenuForm BeachMenuForm = new BeachMenuForm();
            BeachMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HikingMenuForm HikingMenuForm = new HikingMenuForm();
            HikingMenuForm.Show();
            this.Hide();
        }
    }
}
