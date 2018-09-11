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
    public partial class Akropoli : AbstractSightsForm
    {
        //this form presents the Akropoli sight, a part of the sights category
        private int photoID = 1;
        private int bigPhotoID;
        public Akropoli()
        {
            InitializeComponent();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (photoID == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("Akropoli-2.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 2;
            }
            else if (photoID == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile("Akropoli-3.jpg");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                photoID = 3;
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("Akropoli-1.jpg");
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
                this.BackgroundImage = Image.FromFile("Akropoli-1.jpg");
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
                this.BackgroundImage = Image.FromFile("Akropoli-2.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 2;
            }
            else if (bigPhotoID == 2)
            {
                this.BackgroundImage = Image.FromFile("Akropoli-3.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 3;
            }
            else
            {
                this.BackgroundImage = Image.FromFile("Akropoli-1.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
                bigPhotoID = 1;
            }
        }

        private void Akropoli_Load(object sender, EventArgs e)
        {
            check_and_save();
            pictureBox1.BackgroundImage = Image.FromFile("Akropoli-1.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            label3.Text = "Βραβευμένος, το 2012, ως \"εξαιρετικό δείγμα ανάδειξης και προβολής αρχαιολογικών ,\nευρυμάτων\", από την Ευρωπαϊκή οργάνωση Europa Nostra, ο αρχαιολογικός χώρος \nτης Μυκηναϊκής Ακρόπολης του Αγίου Ανδρέα, θεωρείται\n δικαίως ένας από τους σημαντικότερους αρχαιολογικούς χώρους\nστο νησί της Σίφνου.\n\nΤα αρχαιολογικά ευρήματα εδώ μαρτυρούν τη συνεχή κατοίκηση \nαπό τους Μυκηναϊκούς έως τους ελληνιστικούς χρόνους. Οι \nανασκαφές έφεραν στο φως μεγάλο μέρος μυκηναϊκού τείχους του \n12ου αι. π.Χ. Μέσα σε αυτό υπάρχουν τα ερείπια πέντε \nοικοδομημάτων, πιθανόν κατοικιών.";
        }

        private void button2_Click(object sender, EventArgs e)  //this button sends the user to the next sight
        {
            ArchMuseum ArchMuseum = new ArchMuseum(); 
            ArchMuseum.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)      //this button sends the use to the previous sight
        {
            ArxaioiPurgoi ArxaioiPurgoi = new ArxaioiPurgoi();
            ArxaioiPurgoi.Show();
            this.Hide();
        }
    }
}
