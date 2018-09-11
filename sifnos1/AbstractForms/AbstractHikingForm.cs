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
    public partial class AbstractHikingForm : ContentForm
    {
        public AbstractHikingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HikingMenuForm hike = new HikingMenuForm();
            hike.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "txt files (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                String fileName = fd.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                byte[] nl = Encoding.UTF8.GetBytes(Environment.NewLine);
                byte[] one = System.Text.Encoding.UTF8.GetBytes(label1.Text);
                byte[] two = System.Text.Encoding.UTF8.GetBytes(label7.Text);
                byte[] newfileData = one.Concat(nl).Concat(two).ToArray();



                fs.Write(newfileData, 0, newfileData.Length);
                fs.Close();
            }
        }

        private void AbstractHikingForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
