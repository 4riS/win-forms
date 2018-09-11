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
    public partial class KamKapsalos : AbstractHikingForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public KamKapsalos()
        {
            InitializeComponent();
        }

        private void KamKapsalos_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BackgroundImage = Image.FromFile("Distance.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImage = Image.FromFile("Time.jpg");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackgroundImage = Image.FromFile("Difficulty.jpg");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackgroundImage = Image.FromFile("Round.jpg");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            label7.Text = "Το μονοπάτι ξεκινάει από τη νεολιθική ακρόπολη του Αγίου Ανδρέα. Περνώντας από\nόμορφες καλλιεργούμενες εκτάσεις, το μονοπάτι σύντομα προσεγγίζει την Ιερά Μονή\nΒρύσης (16ος αιώνας). Είναι το μοναδικό ανδρικό μοναστήρι της Σίφνου. Κατηφορίζοντας\nαργά, το Κάστρο η θέα του Κάστρου θα ξεδιπλωθεί μπροστά σας. Λίγες εκατοντάδες\nμέτρα ακόμη, μια μικρή ανηφόρα με σκαλοπάτια, και θα φτάσετε στον οικισμό. Το Κάστρο\nκατοικείται από την αρχαιότητα. Ήταν η πρωτεύουσα της Σίφνου έως το 1836.\nΠροτείνουμε να κάνετε μια μικρή στάση, γιατί η ανηφόρα που ακολουθεί είναι αρκετά\nμεγάλη. Το μονοπάτι εισέρχεται αρχικά στον οικισμό του Αγίου Λουκά, και από εκεί στον\nαρχοντικό Αρτεμώνα με τα νεοκλασικά σπίτια του 19ου αιώνα. Εκεί βρίσκεται και το\nτέρμα της διαδρομής, η οποία είναι ένα πραγματικό ταξίδι στο χρόνο!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "View Slideshow")
            {
                button10.Text = "Back to content";
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
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
                label5.Show();
                label6.Show();
                label7.Show();
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
                button6.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
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
            AndreasArtemonas AndreasArtemonas = new AndreasArtemonas();
            AndreasArtemonas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppVathy AppVathy = new AppVathy();
            AppVathy.Show();
            this.Hide();
        }
    }
}
