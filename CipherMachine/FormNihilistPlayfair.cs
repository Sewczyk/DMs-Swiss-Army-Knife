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
using static ControlAndData.Miscellaneous.Constants;

namespace CipherMachine
{
    public partial class FormNihilistPlayfair : Form
    {
        private Controller LocalController;
        public FormNihilistPlayfair(Controller _controller)
        {
            InitializeComponent();
            LocalController = _controller;
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            LocalController.AddNewNihilistPlayfairInstanceToCipheringOrder(NihilistCipherName, textBoxKeyword.Text.ToString());
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
