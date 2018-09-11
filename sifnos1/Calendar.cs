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
    public partial class Calendar : BaseForm
    {
        public Calendar()
        {
            InitializeComponent();
            conn = new OleDbConnection(connectionstring);
        }

        private void show_comments(String dateOfComments)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();

                String query = "SELECT Comments FROM comment WHERE Author='" + LogInForm.current_user_id + "' AND Date='" + monthCalendar1.SelectionRange.Start.ToString() + "'";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Pictures/mainMenuBg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label1.Text = "Δείτε τα σχόλια :";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.BackColor = Color.Transparent;
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            show_comments(monthCalendar1.SelectionRange.Start.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Το σχόλιο πρέπει να είναι μαγελύτερο");
            } else
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into comment ([Comments],[Date],[Author]) values (?,?,?)";
                    cmd.Parameters.AddWithValue("@Comments", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Date", monthCalendar1.SelectionRange.Start.ToString());
                    cmd.Parameters.AddWithValue("@Author", LogInForm.current_user_id);

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

                MessageBox.Show("Το σχόλιο προστέθηκε επιτυχώς");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuForm mmF = new MainMenuForm();
            mmF.Show(this);
            this.Hide();
        }
    }
}
