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
    public partial class ArxaioiPurgoi : AbstractSightsForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public ArxaioiPurgoi()
        {
            InitializeComponent();
        }

        private void ArxaioiPurgoi_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Text = "Εβδομήντα έξι αρχαίοι πύργοι, βρίσκονται διάσπαρτοι, σε όλο το νησί.\nΌλοι είναι στρογγυλοί και χτίστηκαν μεταξύ του 6ου και του 3ου αιώνα π.Χ.\nόπως αποδεικνύεται από τα θραύσματα αρχαίων αγγείων που βρέθηκαν στις\nπεριοχές των πύργων, αλλά και από το μέγεθος και τον τύπο δόμησής τους.\nΤα ευρήματα μαρτυρούν επίσης, ότι οι πύργοι ήταν τουλάχιστον διώροφοι με\nεσωτερικούς διαχωριστικούς τοίχους. Οι περισσότεροι μόλις διακρίνονται.\n\nΟι πύργοι στη Σίφνο που είναι όλοι κυκλικοί με μέση εξωτερική διάμετρο περί\nτα 8 μέτρα, έχουν κατασκευαστεί σε καλλιεργημένες περιοχές, σε κορυφές\nή σε πλαγιές. Συνδέονται με τις ακροπόλεις του νησιού και πιθανότατα χρησίμευαν\nείτε ως φρυκτωρίες είτε ως οχυρά και φυλάκια είτε τέλος, ως αποθηκευτικοί χώροι.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (photoID == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-2.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 2;
            } else if (photoID == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-3.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 3;
            } else
            {
                pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "View Slideshow")
            {
                button10.Text = "Back to content";
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
                pictureBox1.Hide();
                this.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 1;
                timer2.Enabled = true;
            }
            else
            {
                button10.Text = "View Slideshow";
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
                button6.Show();
                pictureBox1.Show();
                this.BackgroundImage = null;
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (bigPhotoID == 1)
            {
                this.BackgroundImage = Image.FromFile("ArxaioiPurgoi-2.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 2;
            }
            else if (bigPhotoID == 2)
            {
                this.BackgroundImage = Image.FromFile("ArxaioiPurgoi-3.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 3;
            }
            else
            {
                this.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Akropoli Akropoli = new Akropoli();
            Akropoli.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolkloreMuseum FolkloreMuseum = new FolkloreMuseum();
            FolkloreMuseum.Show();
            this.Hide();
        }
    }
}
