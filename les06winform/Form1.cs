using ComplexLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les06winform
{
    public partial class Form1 : Form, IViewInterface
    {
        Adapter a;
        public Form1()
        {
            InitializeComponent();
            a = new Adapter(this);
        }

        public string Number1 => txt1.Text;

        public string Number2 => txt2.Text;

        public string OutputData { set => lblResult.Text = value; }

        private void btn_Click(object sender, EventArgs e)
        {
            a.Sum();
        }
    }
}
