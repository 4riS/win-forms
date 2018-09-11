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
    public partial class RegisterForm : BaseForm
    {

        public RegisterForm()
        {
            InitializeComponent();
            OleDbConnection conn = null;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Pictures/mainBg.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Text = "Παρακαλώ πληκτρολογήστε\nσωστά τα στοιχεία σας\nώστε να πραγματοποιήσετε\nτην εγγραφή σας !";
        }

        private void submit_Click(object sender, EventArgs e)
        {


            try
            {
                conn = new OleDbConnection(connectionstring);

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into login ([username],[password]) values (?,?)";
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);


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

            LogInForm first = new LogInForm();
            first.Show(this);
            this.Hide();
        }
    }
}
