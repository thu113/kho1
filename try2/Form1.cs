using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int k = int.Parse(this.textBox1.Text);
            int h = int.Parse(this.textBox2.Text);
<<<<<<< HEAD
            if(k != 0 && k!= 1)
=======
            if(k == 10)
>>>>>>> anh
            this.textBox3.Text = (k + h).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = null;
            this.textBox2.Text = null;
            this.textBox3.Text = null;
        }
    }
}
