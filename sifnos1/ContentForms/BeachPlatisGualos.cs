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
    public partial class BeachPlatisGualos : AbstractBeachForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public BeachPlatisGualos()
        {
            InitializeComponent();
        }

        private void BeachPlatisGualos_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("PlatusGialos-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label4.Text = "Το τοπωνύμιο προέρχεται από το Πλατύς Αιγιαλός και σημαίνει ακρογιάλι που\nέχει σχετικά μεγάλο πλάτος, ευρύχωρη ακροθαλασσιά.\n\nΕίναι η πιο πολυσύχναστη παραλία του νησιού, η οποία επί σειρά ετών βραβεύεται\nμε την γαλάζια σημαία της Ευρωπαϊκής Ένωσης. Πηγαίνοντας στον Πλατύ Γιαλό από\nτην Απολλωνία, λίγο μετά τη μέση της διαδρομής ο δρόμος στα δεξιά σας οδηγεί στο\nμοναστήρι της Παναγιάς του Βουνού(1813) απ όπου η πανοραμική θέα της παραλίας\nτου Πλατύ Γιαλού είναι μαγευτική. Βορειοανατολικά της παραλίας βρίσκεται ο Άσπρος\nΠύργος ο πιο γνωστός από τους 55 αρχαίους πύργους της Σίφνου που δυστυχώς δεν\nείναι επισκέψιμος. Νότια, στο ακρωτηράκι του Πλατύ Γιαλού, ανακαλύφθηκε προϊστορικό\nνεκροταφείο που επίσης δε θα μπορέσετε να δείτε.";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (photoID == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("PlatusGialos-2.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 2;
            } else if (photoID == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile("PlatusGialos-3.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 3;
            } else
            {
                pictureBox1.BackgroundImage = Image.FromFile("PlatusGialos-1.jpg");
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
                this.BackgroundImage = Image.FromFile("PlatusGialos-1.jpg");
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
                this.BackgroundImage = Image.FromFile("PlatusGialos-2.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 2;
            }
            else if (bigPhotoID == 2)
            {
                this.BackgroundImage = Image.FromFile("PlatusGialos-3.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 3;
            }
            else
            {
                this.BackgroundImage = Image.FromFile("PlatusGialos-1.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spilia Spilia = new Spilia();
            Spilia.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poulati Poulati = new Poulati();
            Poulati.Show();
            this.Hide();
        }
    }
}
