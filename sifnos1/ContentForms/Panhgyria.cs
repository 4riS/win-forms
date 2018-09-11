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
    public partial class Panhgyria : AbstractActivityForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public Panhgyria()
        {
            InitializeComponent();
        }

        private void Panhgyria_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Text = "Οι κάτοικοι της Σίφνου, τηρώντας τα έθιμα και τις παραδόσεις, διοργανώνουν\nπανηγύρια σε ξωκλήσια και μοναστήρια, όλο το χρόνο.\n\nΣτα περισσότερα από αυτά προσφέρεται φαγητό μαγειρεμένο παραδοσιακά\nστη φωτιά των ξύλων (ρεβυθάδα και κρέας με μακαρόνια) και άφθονο κρασί.\nΌταν το πανηγύρι πέφτει σε περίοδο νηστείας, το 'μενού' αλλάζει και αντί για\nκρέας σερβίρεται μπακαλιάρος.Το γλέντι ξεκινάει αφού τελειώσει ο εσπερινός,\nυπό τους ήχους των παραδοσιακών οργάνων, βιολί και λαούτο. Στην τοπική\nδιάλεκτο το ζεύγος των μουσικών που παίζουν βιολί και λαούτο, λέγεται τακίμι.\n\nΤις περισσότερες φορές το γλέντι κρατάει μέχρι τις πρώτες πρωινές ώρες,\nμε τραγούδι, χορό και αυτοσχέδιες ρίμες.Μην χάσετε την ευκαιρία να\nεπισκεφθείτε κάποιο πανηγύρι! Ρωτήστε τους ντόπιους αν κάποια από τις ημέρες\nτης διαμονής σας στο νησί, διοργανώνεται κάποιο πανηγύρι.";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (photoID == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-2.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 2;
            }
            else if (photoID == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-3.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 3;
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 1;
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
            Tselementes Tselementes = new Tselementes();
            Tselementes.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tselementes Tselementes = new Tselementes();
            Tselementes.Show();
            this.Hide();
        }
    }
}
