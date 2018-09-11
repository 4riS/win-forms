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
    public partial class Mastelo : AbstractProductForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public Mastelo()
        {
            InitializeComponent();
        }

        private void Mastelo_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label2.Text = "ΥΛΙΚΑ :\n-5-6 κιλά αρνάκι ή κατσικάκι κομμένο σε μερίδες\n-κόκκινο κρασί\n-μπόλικο ψιλοκομμένο άνηθο\n-μπόλια (προαιρετική)\n-αλάτι\n-πιπέρι\n-κληματόβεργες.";
            label3.Text = "ΕΚΤΕΛΕΣΗ :\nΠλένουμε το κρέας με κόκκινο κρασί. Τα αλατοπιπερώνουμε καλά και πασπαλίζουμε\nόλες τις μερίδες με άνηθο. Στρώνουμε στον πάτο από το μαστέλο (ειδικό πήλινο\nσκεύος για το συγκεκριμένο φαγητό χωρίς καπάκι) χιαστί τις κληματόβεργες\nσχηματίζοντας μία σχάρα. Πάνω από τις κληματόβεργες τοποθετούμε τα κομμάτια\nτου κρέατος. Αν θέλουμε βάζουμε στο τέλος πάνω από τα κομμάτια του κρέατος\nμπόλια για να μη στεγνώσουν. Το καταβρέχουμε με 1 ½ - 2 ποτηράκια του κρασιού\nκόκκινο κρασί. Σκεπάζουμε καλά με αλουμινόχαρτο, στο οποίο με ένα πιρούνι\nή μαχαιράκι κάνουμε μικρές τρυπίτσες. Το βάζουμε στον ξυλόφουρνο να ψηθεί\nγια 4 ½ με 5 ώρες!";
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
            Amugdalota Amugdalota = new Amugdalota();
            Amugdalota.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Melopitha Melopitha = new Melopitha();
            Melopitha.Show();
            this.Close();
        }
    }
}
