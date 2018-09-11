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
    public partial class Rebuthada : AbstractProductForm
    {
        private int photoID = 1;
        private int bigPhotoID;

        public Rebuthada()
        {
            InitializeComponent();
        }

        private void Rebuthada_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label2.Text = "ΥΛΙΚΑ :\n-1 κιλό ρεβίθια\n-¾ του κιλού ψιλοκομμένα κρεμμύδια\n-¾ ποτήρι του νερού ελαιόλαδο\n-αλάτι και πιπέρι\n-νερό";
            label3.Text = "ΕΚΤΕΛΕΣΗ :\nΑπό βραδύς μουλιάζουμε τα ρεβίθια σε νερό και τα αφήνουμε να φουσκώσουν.\nΤο πρωί τα ξεπλένουμε καλά (3-4 νερά) και τα βάζουμε στη σκεπασταριά (πήλινο\nσκεύος για τη ρεβιθάδα) και τους προσθέτουμε το ψιλοκομμένο κρεμμύδι, το λάδι,\nαλατοπίπερο και νερό. Το νερό που προσθέτουμε πρέπει γέρνοντας στο πλάι τη\nσκεπασταριά να φθάνει στην άκρη του χείλους της και συγχρόνως να καλύπτει τα\nρεβίθια. Καλύπτουμε τη σκεπασταριά με το καπάκι της και τη βάζουμε στον\nξυλόφουρνο και αφήνουμε τη ρεβιθάδα να σιγοψηθεί για 6 περίπου ώρες!";
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
            Melopitha Melopitha = new Melopitha();
            Melopitha.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Amugdalota Amugdalota = new Amugdalota();
            Amugdalota.Show();
            this.Close();
        }
    }
}
