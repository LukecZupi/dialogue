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

namespace whatever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sporočilnoOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To je osnovno sporočilo okno");
        }

        private void zNapisomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To se izpiše v okno", "Tole piše na oknu");
        }

        private void zDvemaGumbomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ali potrjuješ brisanje?", "POZOR!", MessageBoxButtons.YesNo) == DialogResult.Yes) { MessageBox.Show("Izbrisano");}
        }

        private void sTremiGumbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odg = MessageBox.Show("Ali shranim in zakljucim", "pozor!", MessageBoxButtons.YesNoCancel);

            if (odg == DialogResult.Yes) { MessageBox.Show("Podatki so shranjeni"); }
            else if (odg == DialogResult.No) { MessageBox.Show("V redu potem pa ne"); }
            else { MessageBox.Show("Nadaljuj z delom"); }
        }

        private void zIkonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napaka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) ;
            {
                //z izbrano barvo pobarvamo background obrazca
                this.BackColor = colorDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) ;
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
    }
}
