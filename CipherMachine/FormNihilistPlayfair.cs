using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlAndData;
using ControlAndData.Ciphers;

namespace CipherMachine
{
    public partial class FormNihilistPlayfair : Form
    {
        private Controller LocalController;
        private string CipherName;
        public FormNihilistPlayfair(Controller _controller, string _cipherName)
        {
            InitializeComponent();
            LocalController = _controller;
            CipherName = _cipherName;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            LocalController.CreateNihilistCipherInstance(CipherName, textBoxKeyword.ToString());
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
