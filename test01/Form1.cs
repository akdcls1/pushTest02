using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("box1");
        }
        public void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("box2");
        }

    }
}
