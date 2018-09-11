using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sifnos1
{
    public partial class BeachMenuForm : AbstractMenuForm
    {

        public BeachMenuForm()
        {
            InitializeComponent();

           
        }

        private void BeachMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("BeachIcons/beach-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("BeachIcons/beach-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("BeachIcons/beach-3.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox7.BackgroundImage = Image.FromFile("BeachIcons/beach-4.png");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BackColor = System.Drawing.Color.Transparent;

            remember("BeachPlatisGualos", 1);
            remember("Spilia", 2);
            remember("Vroulidia", 3);
            remember("Poulati", 4);



        }

        private void label1_Click(object sender, EventArgs e)
        {
            BeachPlatisGualos BeachPlatisGualos = new BeachPlatisGualos();
            BeachPlatisGualos.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Spilia Spilia = new Spilia();
            Spilia.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Vroulidia Vroulidia = new Vroulidia();
            Vroulidia.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Poulati Poulati = new Poulati();
            Poulati.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SightsMenuForm SightsMenuForm = new SightsMenuForm();
            SightsMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelMenuForm HotelMenuForm = new HotelMenuForm();
            HotelMenuForm.Show();
            this.Hide();
        }
    }
}
