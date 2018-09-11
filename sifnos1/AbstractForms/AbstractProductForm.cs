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
    public partial class AbstractProductForm : ContentForm
    {
        public AbstractProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductMenuForm product = new ProductMenuForm();
            product.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "txt files (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                String fileName = fd.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                List<byte[]> myList = new List<byte[]>();
                byte[] nl = Encoding.UTF8.GetBytes(Environment.NewLine);
                for (int i = 1; i < 4; i++)
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

        private void AbstractProductForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
