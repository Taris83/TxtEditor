using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace EditeurDeTexte
{
    public partial class FrmMain : Form
    {
        Editor edit;

        public FrmMain()
        {
            InitializeComponent();
            edit = new Editor(rpRichTextBox1);
        }

        private void mnuNouveau_Click(object sender, EventArgs e)
        {
            this.Text = "Mon Petit Editeur";
            edit.newFile();
        }

        private void mnuOuvrir_Click(object sender, EventArgs e)
        {
            this.Text = "Mon Petit Editeur - " + edit.openFile();
        }

        private void mnuEnregistrer_Click(object sender, EventArgs e)
        {
            edit.saveFile();
        }

        private void mnuEnregistrerSous_Click(object sender, EventArgs e)
        {
            edit.saveAsFile();
            this.Text = "Mon Petit Editeur - " + edit.getFileName();
        }


        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAnnuler_Click(object sender, EventArgs e)
        {
            edit.undo();
        }

        private void mnuRetablir_Click(object sender, EventArgs e)
        {
            edit.redo();
        }

        private void mnuCouper_Click(object sender, EventArgs e)
        {
            edit.cut();
        }

        private void mnuCopier_Click(object sender, EventArgs e)
        {
            edit.copy();
        }

        private void mnuColler_Click(object sender, EventArgs e)
        {
            edit.paste();
        }

        private void mnuSellectionnerTout_Click(object sender, EventArgs e)
        {
            edit.selectAll();
        }

        private void rtbBlocTexte_TextChanged(object sender, EventArgs e)
        {
            edit.setText(rtbBlocTexte.Text);
        }

        private void mnuAPropos_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
    }
}
