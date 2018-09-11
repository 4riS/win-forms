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
    public partial class ArchMuseum : AbstractSightsForm
    {
        private int photoID = 1;
        private int bigPhotoID;
        public ArchMuseum()
        {
            InitializeComponent();
        }

        private void ArchMuseum_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("ArxaioiPurgoi-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Text = "Το μουσείο περιλαμβάνει συλλογές αρχαϊκών και ελληνιστικών γλυπτών.\nΤα γλυπτά (επιτύμβια, αγάλματα, αρχιτεκτονικά μέλη κ.ά.) είναι από την αρχαϊκή (6ος αιώνας π.Χ.)\nμέχρι και τη ρωμαϊκή εποχή (1ος αιώνας π.Χ.).\nΤα κεραμικά είναι από την περιοχή του Κάστρου και χρονολογούνται \nαπό τη γεωμετρική (8ος αιώνας π.Χ.) μέχρι και την ελληνιστική εποχή (2ος αιώνας π.Χ).\n\nΣημαντικά εκθέματα είναι:\nΜια ανθεμωτή επίστεψη μαρμάρινης επιτύμβιας στήλης από τον 4ο αιώνα π.Χ.\nΕνα κεφάλι από μαρμάρινο γυναικείο άγαλμα από τον 4ο αιώνα π.Χ.\nΕνα μαρμάρινο κεφάλι κούρου από τα μέσα του 6ου αιώνα π.Χ.\nΕνα μαρμάρινο ιωνικό κιονόκρανο του 6ου αιώνα π.Χ.\nΜια μαρμάρινη επιτύμβια στήλη από τους ελληνιστικούς χρόνους";
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
            FolkloreMuseum FolkloreMuseum = new FolkloreMuseum();
            FolkloreMuseum.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Akropoli Akropoli = new Akropoli();
            Akropoli.Show();
            this.Hide();
        }
    }

}
