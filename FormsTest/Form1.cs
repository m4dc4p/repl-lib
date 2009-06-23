using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.repl1.AddExternalObject("Form1", this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
