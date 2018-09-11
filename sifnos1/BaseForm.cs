using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sifnos1
{
    public partial class BaseForm : Form      //this is the form all other forms in the project inherit from
    {


        protected String connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db1.mdb"; 
        protected OleDbConnection conn;
        protected  static HashSet<String> visited = new HashSet<String>();  
        public static String current_user_id = null;

        public BaseForm()
        {
            InitializeComponent();
            try
            {
                conn = new OleDbConnection(connectionstring);
            } catch (Exception e)
            {
                MessageBox.Show("Πρόβλημα με την σύνδεση της βάσης. Προσπαθήστε ξανά !");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_history();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_history();
            Application.Exit();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            if (music.isOn == true)
            {
                pictureBox4.Show();
                pictureBox5.Hide();
            }
            else
            {
                pictureBox4.Hide();
                pictureBox5.Show();
            }
        }

        protected void delete_history()   //deletes history of guest from the database
        {

            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from  forms  where visitor_name=@gname";
                cmd.Parameters.AddWithValue("@gname", "guest");

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Παρουσιάστηκε κάποιο σφάλμα. Δοκιμάστε ξανά !");
            }
            finally
            {
                conn.Close();
            }


        }

        protected void remember(String name, int index)
        {
            String ind = index.ToString();
            var labelId = "label" + ind;
            var label = Controls[labelId];
            if (visited.Contains(name))
            {
                label.Font = new Font(label.Font, FontStyle.Underline);
            }
        }

        protected void save_visit(String form_name)          //saves the visitor id and the form currently opening in the database
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into forms ([form_name],[visitor_name]) values (?,?)";
                cmd.Parameters.AddWithValue("@form_name", form_name);
                cmd.Parameters.AddWithValue("@visitor_name", current_user_id);

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Παρουσιάστηκε κάποιο σφάλμα. Δοκιμάστε ξανά !");
            }
            finally
            {
                conn.Close();
            }
            db_to_hashset();
        }

        protected void db_to_hashset()         //stores in a hashset the names of the forms that the current user has visited in this session or in previous ones
        {
            try
            {
                conn = new OleDbConnection(connectionstring);
                conn.Open();

                String query = "Select form_name,visitor_name from forms where visitor_name='" + current_user_id + "'";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    String fname = rdr.GetValue(0).ToString();
                    visited.Add(fname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Παρουσιάστηκε κάποιο σφάλμα. Δοκιμάστε ξανά !");
            }
            finally
            {
                conn.Close();
            }
        }





        protected void check_and_save()
        {
            if (visited.Contains(this.Text.ToString()))
            {
                //menuStrip1.Visible = false;
                //MessageBox.Show("You ," + BaseForm.current_user_id + ", have been here before");
                //this.BackColor = Color.Red;
            }
            this.save_visit(this.Text.ToString());
        }









        private void pictureBox1_Click(object sender, EventArgs e)
        {
            delete_history();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Μια εφαρμογή για το μάθημα 'Ταχεία Ανάπτυξη Εφαρμογών'\nτων Γεωργούλη Αριστοτέλη και Σανιδά Γεώργιο");
        }

        private void ελαχιστοποίησηΕφαρμογήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            music.stopMusic();
            pictureBox4.Hide();
            pictureBox5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            music.playMusic();
            pictureBox5.Hide();
            pictureBox4.Show();
        }

        private void πληροφορίεςΔημιουργώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs abtu = new AboutUs();
            abtu.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSifnos abts = new AboutSifnos();
            abts.Show();
        }
    }
}
