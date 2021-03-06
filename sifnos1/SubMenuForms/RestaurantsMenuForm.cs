﻿using System;
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
    public partial class RestaurantsMenuForm : AbstractMenuForm
    {
        public RestaurantsMenuForm()
        {
            InitializeComponent();
        }

        private void RestaurantsMenuForm_Load(object sender, EventArgs e)
        {
            check_and_save();
            this.BackgroundImage = Image.FromFile("Pictures/MainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;

            pictureBox4.BackgroundImage = Image.FromFile("RestIcons/rest-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("RestIcons/rest-2.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("RestIcons/rest-3.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;

            remember("ToSteki", 1);
            remember("Iliovasilemacs", 2);
            remember("IOreaSifnos", 3);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ToSteki ToSteki = new ToSteki();
            ToSteki.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Iliovasilemacs Iliovasilemacs = new Iliovasilemacs();
            Iliovasilemacs.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            IOreaSifnos IOreaSifnos = new IOreaSifnos();
            IOreaSifnos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarMenuForm BarMenuForm = new BarMenuForm();
            BarMenuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SightsMenuForm SightsMenuForm = new SightsMenuForm();
            SightsMenuForm.Show();
            this.Hide();
        }
    }
}
