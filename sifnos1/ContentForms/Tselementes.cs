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
    public partial class Tselementes : AbstractActivityForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public Tselementes()
        {
            InitializeComponent();
        }

        private void Tselementes_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Text = "Αντιπροσωπείες από τα νησιά των Κυκλάδων, μαζί με κάποιου τιμώμενου νησιού\nαπό το υπόλοιπο Αιγαίο, ανταμώνουν στη Σίφνο και παρουσιάζουν την ιδιαίτερη\nγαστρονομική και πολιτιστική τους παράδοση. Κάθε νησί έχει το δικό του\nπερίπτερο στην κεντρική πλατεία του Αρτεμώνα, όπου ερασιτέχνες μαζί με\nεπαγγελματίες μάγειρες και σεφ, παρασκευάζουν και παρουσιάζουν τις συνταγές\nτου τόπου τους. Τις γεύσεις αυτές, οι επισκέπτες μπορούν να δοκιμάσουν\nστα περίπτερα των νησιών.\n\nΣε μια διαμορφωμένη γωνιά της πλατείας, τα 'Τσελεμεντάκια'(παιδιά ηλικίας 6 έως\n12 ετών), ντυμένα με ποδιές και πολύχρωμους μαγειρικούς σκούφους, συμμετέχουν\nσε μαγειρικά παιχνίδια και διαγωνισμούς, φτιαγμένους στα μέτρα τους.";
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
            Panhgyria Panhgyria = new Panhgyria();
            Panhgyria.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panhgyria Panhgyria = new Panhgyria();
            Panhgyria.Show();
            this.Hide();
        }
    }
}
