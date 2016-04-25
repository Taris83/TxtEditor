using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditeurDeTexte
{
    class Editor
    {
        private string _text;
        private string _path;
        private bool _isOnceSavedFile;
        private RichTextBox _rtb;
        
        
        public Editor(RichTextBox RTB)
        {
            _rtb = RTB;
            _isOnceSavedFile = false;
            _text = "";
            _path = "";
        }
        
        public void newFile()
        {
            askSave();
           
        }

        public string openFile()
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Ouvrir un fichier texte...";
            ofd.Filter = "Fichier texte|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                _path = ofd.FileName;
                _text = System.IO.File.ReadAllText(ofd.FileName);
                _rtb.Text = _text;
                _isOnceSavedFile = true;
            }
            return ofd.SafeFileName;
        }

        public string getFileName()
        {
            return Path.GetFileName(_path);
        }

        private bool checkSaveOnce()
        {
            return _isOnceSavedFile ? true : false;
        }

        private void newFileRoutine()
        {
            _text = "";
            _path = "";
            _isOnceSavedFile = false;
            _rtb.Text = "";
        }

        private void askSave()
        {
            if (_text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous enregistrer le fichier avant de créer un nouveau fichier ?", "Nouveau Fichier", 
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    saveAsFile();
                else if (dialogResult == DialogResult.No)
                    newFileRoutine();
            }
            else
                newFileRoutine();
                
        }

        public void setText(string txt)
        {
            _text = txt;
        }



        public void saveFile()
        {
            if (!checkSaveOnce())
            {
                saveAsFile();
            }
            else
                _rtb.SaveFile(_path, RichTextBoxStreamType.PlainText);


        }

        public void saveAsFile()
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Sauvegarder un fichier texte...";
            sfd.Filter = "Fichier texte|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _path = sfd.FileName;

                _rtb.SaveFile(_path, RichTextBoxStreamType.PlainText);
            }
        }

        public void cut()
        {
            _rtb.Cut();
        }

        public void copy()
        {
            _rtb.Copy();
        }

        public void paste()
        {
            _rtb.Paste();
        }
        
        public void undo()
        {
            _rtb.Undo();
        }

        public void redo()
        {
            _rtb.Redo();
        }

        public void selectAll()
        {
            _rtb.SelectAll();
        }
    }
}
