using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sifnos1
{
    public partial class MainMenuForm : BaseForm
    {

        public MainMenuForm()
        {
            InitializeComponent();

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            db_to_hashset();
            this.BackgroundImage = Image.FromFile("Pictures/mainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            if (current_user_id == "guest")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }

            remember("BeachMenuForm", 2);
            remember("SightsMenuForm", 3);
            remember("HikingMenuForm", 8);
            remember("RestaurantsMenuForm", 4);
            remember("BarMenuForm", 5);
            remember("ActivityMenuForm", 6);
            remember("ProductMenuForm", 7);
            remember("HotelMenuForm", 9);


            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;

            pictureBox1.BackgroundImage = Image.FromFile("MainMenuIcons/beach-1.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = Image.FromFile("MainMenuIcons/aksiotheata-1.png");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackgroundImage = Image.FromFile("MainMenuIcons/est-1.png");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.BackgroundImage = Image.FromFile("MainMenuIcons/bar-1.png");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackgroundImage = Image.FromFile("MainMenuIcons/festival-1.png");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.BackgroundImage = Image.FromFile("MainMenuIcons/food-1.png");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox7.BackgroundImage = Image.FromFile("MainMenuIcons/hiking-1.png");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BackColor = System.Drawing.Color.Transparent;
            pictureBox8.BackgroundImage = Image.FromFile("MainMenuIcons/hotel-1.png");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.BackColor = System.Drawing.Color.Transparent;
        }





        private void label2_Click(object sender, EventArgs e)
        {
            BeachMenuForm BeachMenuForm = new BeachMenuForm();
            BeachMenuForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SightsMenuForm SightsMenuForm = new SightsMenuForm();
            SightsMenuForm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HikingMenuForm HikingMenuForm = new HikingMenuForm();
            HikingMenuForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RestaurantsMenuForm RestaurantsMenuForm = new RestaurantsMenuForm();
            RestaurantsMenuForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BarMenuForm BarMenuForm = new BarMenuForm();
            BarMenuForm.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ActivityMenuForm ActivityMenuForm = new ActivityMenuForm();
            ActivityMenuForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ProductMenuForm ProductMenuForm = new ProductMenuForm();
            ProductMenuForm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            HotelMenuForm HotelMenuForm = new HotelMenuForm();
            HotelMenuForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_history();
            MessageBox.Show("Το ιστορικό σας διαγράφηκε επιτυχώς !");
        }



        private void clear_history()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  forms  where visitor_name=@gname";    
            cmd.Parameters.AddWithValue("@gname", current_user_id);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            visited.Clear();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("MainMenuIcons/beach-2.png");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Image.FromFile("MainMenuIcons/aksiotheata-2.png");
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("MainMenuIcons/est-2.png");
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("MainMenuIcons/bar-2.png");
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Image.FromFile("MainMenuIcons/festival-2.png");
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Image.FromFile("MainMenuIcons/food-2.png");
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Image.FromFile("MainMenuIcons/hiking-2.png");
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Image.FromFile("MainMenuIcons/hotel-2.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendar calr = new Calendar();
            calr.Show(this);
            this.Hide();
        }

        private void MainMenuForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 105)
            {
                MessageBox.Show("Μπορείτε να δείτε το κυρίως μενού\nκαι να περιηγηθείτε στις κατηγορίες !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogInForm log = new LogInForm();
            log.Show();
            this.Hide();
            visited.Clear();
            delete_history();

        }   
    }
}
