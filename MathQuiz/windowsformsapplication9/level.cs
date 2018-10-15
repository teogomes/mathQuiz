using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class level : Form
    {
        public static int epipedo=8;
        
       
        public level()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            epipedo = 3;
            Form1 form = new Form1(epipedo,textBox1.Text);
            this.Hide();
            form.Show();
            
        }

        private void level_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            epipedo = 1;
            Form1 form = new Form1(epipedo, textBox1.Text);
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            epipedo = 2;
            Form1 form = new Form1(epipedo, textBox1.Text);
            this.Hide();
            form.Show();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lime;
           
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }
    }
}
