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
    public partial class AboutSifnos : BaseForm
    {
        public AboutSifnos()
        {
            InitializeComponent();
        }

        private void AboutSifnos_Load(object sender, EventArgs e)
        {
            label199.BackColor = System.Drawing.Color.Transparent;
            label299.BackColor = System.Drawing.Color.Transparent;
            label299.Text = "Η Σίφνος ανήκει στο σύμπλεγμα των δυτικών\nΚυκλάδων και βρίσκεται ανάμεσα στα\nπλησιέστερα νησιά Σέριφο, Κίμωλο,\nΜήλο, Πάρο. Απέχει από τον Πειραιά\n75 μίλια.Η διάρκεια του ταξιδιού απο\nτον Πειραιά με το πλοίο της γραμμής\nειναι 5 ώρες και με τα ταχύπλοα περίπου\n3 ώρες. Σύμφωνα με την επικρατέστερη\nεκδοχή, το όνομα Σίφνος αποδόθηκε\nστο νησί από το ανθρωπωνύμιο\nΣίφνος του οικιστή του νησιού,\nπου ήταν γιός του ήρωα\nτης Αττικής Σουνίου.";
            webBrowser1.Navigate("https://www.google.gr/maps/place/Sifnos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
