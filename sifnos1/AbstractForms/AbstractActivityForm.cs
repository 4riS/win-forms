using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace sifnos1
{
    // this form serves as a template for all the forms presenting the different activities the island of Sifnos provides
    public partial class AbstractActivityForm : ContentForm
    {
        public AbstractActivityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   // this button returns the user to the activities submenu
        {
            ActivityMenuForm act = new ActivityMenuForm();
            act.Show();
            this.Hide();
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "txt files (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                String fileName = fd.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                List<byte[]> myList = new List<byte[]>();
                byte[] nl = Encoding.UTF8.GetBytes(Environment.NewLine);
                for (int i=1;i<4;i++)
                {
                    var index = i.ToString();
                    var labelId = "label" + index;
                    var label = Controls[labelId];
                    byte[] f = System.Text.Encoding.UTF8.GetBytes(label.Text);
                    myList.Add(f);
                    myList.Add(nl);
                }
                byte[] fileData = myList.SelectMany(byteArr => byteArr).ToArray();




                fs.Write(fileData, 0, fileData.Length);
                fs.Close();
            }


        }

        private void AbstractActivityForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
