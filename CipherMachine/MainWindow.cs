using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlAndData;


namespace CipherMachine
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string globalFont;
        private float globalFontSize = 2;
        private bool isChanged = false;
        Controller ControllerAndData = new Controller();


        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBoxFonts.Items.Add(font.Name.ToString());
                if (font.Name.ToString() == "Times New Roman")
                {
                    globalFont = font.Name.ToString();
                    toolStripComboBoxFonts.Text = globalFont;
                }
            }
            for(int i=0;i<comboBoxFontsSize.Items.Count;i++)
            {
                if(comboBoxFontsSize.Items[i].ToString()=="16")
                {
                    comboBoxFontsSize.SelectedIndex = i;
                    globalFontSize = float.Parse(comboBoxFontsSize.Items[i].ToString());
                    break;
                }
            }
            textSource.Font = new Font(globalFont, globalFontSize);
            
            foreach(string obj in ControllerAndData.AllCiphers)
            {
                listBoxAvilableCiphers.Items.Add(obj);
            }
        }
        #region Toolstrip Menu on click Actions

        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSource.Clear();
            Form newForm = new Form();
            newForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (.txt) | *.txt";
            ofd.Title = "Otwórz";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                textSource.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (.txt) | *.txt";
            sfd.Title = "Zapisz";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(textSource.Text);
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (.txt) | *txt";
            sfd.Title = "Zapisz";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(textSource.Text);
                sw.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {

            }
            else
            {
                Application.Exit();
            }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSource.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSource.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSource.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSource.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSource.Paste();
        }

        private void toolStripComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textSource.SelectionFont = new Font(toolStripComboBoxFonts.Text, globalFontSize);

        }

        private void comboBoxFontsSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            textSource.SelectionFont = new Font(globalFont,float.Parse(comboBoxFontsSize.Text.ToString()));
        }

        private void textSource_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        #endregion

        private void buttonAddToCipheringOrder_Click(object sender, EventArgs e)
        {
            
        }

        private Form FormFactory(Controller _controller)
        {
            return null;
        }
    }
}
