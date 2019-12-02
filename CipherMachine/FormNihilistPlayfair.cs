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
        private CipherDataContainer container;
        public FormNihilistPlayfair(CipherDataContainer _controller)
        {
            InitializeComponent();
            container = _controller;
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            container.AddNihilistInstance(NihilistCipherName, textBoxKeyword.Text.ToString());
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
