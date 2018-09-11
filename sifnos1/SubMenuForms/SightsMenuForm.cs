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
    public partial class SightsMenuForm : AbstractMenuForm
    {
        public SightsMenuForm()
        {
            InitializeComponent();
        }

        private void SightsMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("SightsIcons/sight-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("SightsIcons/sight-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("SightsIcons/sight-3.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox7.BackgroundImage = Image.FromFile("SightsIcons/sight-4.png");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BackColor = System.Drawing.Color.Transparent;

            remember("ArxaioiPurgoi", 1);
            remember("Akropoli", 2);
            remember("ArchMuseum", 3);
            remember("FolkloreMuseum", 4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ArxaioiPurgoi ArxaioiPurgoi = new ArxaioiPurgoi();
            ArxaioiPurgoi.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Akropoli Akropoli = new Akropoli();
            Akropoli.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ArchMuseum ArchMuseum = new ArchMuseum();
            ArchMuseum.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FolkloreMuseum FolkloreMuseum = new FolkloreMuseum();
            FolkloreMuseum.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantsMenuForm RestaurantsMenuForm = new RestaurantsMenuForm();
            RestaurantsMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeachMenuForm BeachMenuForm = new BeachMenuForm();
            BeachMenuForm.Show();
            this.Hide();
        }
    }
}
