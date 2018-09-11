using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifnos1
{
    public partial class LogInForm : BaseForm
    {

        public LogInForm()
        {
            InitializeComponent();
            OleDbConnection conn = null;
            if (music.isOn==false)
            {
                music.addPlayer();
                music.playMusic();
            }

        }

        private void register_Click(object sender, EventArgs e)   //creates a register form 
        {
            RegisterForm reg_form = new RegisterForm();
            reg_form.Show(this);
            this.Hide();
        }

        private void loggedin_Click(object sender, EventArgs e)     // checks if the user has given correct credentials
        {
            try
            {
                conn = new OleDbConnection(connectionstring);
                conn.Open();

                String query = "Select id,username from login where username='" + textBox1.Text + "'  and password='" + textBox2.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                OleDbDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    current_user_id = rdr.GetValue(1).ToString();         //saves the username to the public variable current_user_id.This is now the active user
                    MainMenuForm home = new MainMenuForm();        //sends the user to the main menu of the app
                    home.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Δεν βρέθηκε χρήστης. Προσπαθήστε ξανά !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Φαίνεται ότι παρουσιάστηκε κάποιο σφάλμα. Δοκιμάστε ξανά !");
            }
            finally
            {
                conn.Close();
            }
        }

        private void guest_Click(object sender, EventArgs e)  //allow the user to enter the app as a guest.
        {
            current_user_id = "guest";           //guest is now the active user
            MainMenuForm home = new MainMenuForm();
            home.Show();
            Hide();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Pictures/mainBg.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
