using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginJose
{ 
    public partial class Form1 : Form
    {
        public static Label Label1_1;
        public Form1()
        {
            Label1_1 = label1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Label1_1.ForeColor = Color.Red;
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
