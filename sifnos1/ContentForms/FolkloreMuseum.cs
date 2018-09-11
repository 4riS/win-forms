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
    public partial class FolkloreMuseum : AbstractSightsForm
    {
        private int photoID = 1;
        private int bigPhotoID;
        public FolkloreMuseum()
        {
            InitializeComponent();
        }

        private void FolkloreMuseum_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Text = "Το μουσείο βρίσκεται στην κεντρική πλατεία (πλατεία Ηρώων) της Απολλωνίας.\nΠεριλαμβάνει εκθέματα από την παραδοσιακή ζωή του νησιού, όπως αγροτικά εργαλεία,\nείδη οικιακής χρήσης, τοπικές ενδυμασίες και άλλα.\nΤα κυριότερα εκθέματα είναι: συλλογές σπαθιών, τουφεκιών\nκαι παλιών ενδυμασιών, ξυλόγλυπτα και μπαούλα, κεντήματα και δαντέλες, είδη οκιακής χρήσης,\nαγροτικά σκεύη, είδη σκιαδικής, μελισσοκομικής και αγγειοπλαστικής,\nκαθώς και προτομές Σιφνιών προσωπικοτήτων.\n\nΟι πύργοι στη Σίφνο που είναι όλοι κυκλικοί με μέση εξωτερική διάμετρο περί\nτα 8 μέτρα, έχουν κατασκευαστεί σε καλλιεργημένες περιοχές, σε κορυφές\nή σε πλαγιές. Συνδέονται με τις ακροπόλεις του νησιού και πιθανότατα χρησίμευαν\nείτε ως φρυκτωρίες είτε ως οχυρά και φυλάκια είτε τέλος, ως αποθηκευτικοί χώροι.";
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
            ArxaioiPurgoi ArxaioiPurgoi = new ArxaioiPurgoi();
            ArxaioiPurgoi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArchMuseum ArchMuseum = new ArchMuseum();
            ArchMuseum.Show();
            this.Hide();
        }
    }
}
