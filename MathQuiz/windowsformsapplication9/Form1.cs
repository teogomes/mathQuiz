using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        int s,St = 1;
        int en;
        int swstes = 0;
        int x = 1;
        public bool flag =true;
        public int pro1, pro2, afe1, afe2, pol1, pol2, die1,die2;
        public static int epipedo2;
        public int xronos = 30;
        public int fash = 0, telxronos = 0;
        public String name2;
        String[] name = new String[5];
        int[] Sc = new int[5];
        public Form1(int epipedo,String name)
        {
            epipedo2 = epipedo;
             name2 = name;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            try
            {
                StreamReader scores = new StreamReader("scores.txt");
                for (int i = 0; i < 5; i++)
                {
                    name[i] = scores.ReadLine();
                    Sc[i] = Int32.Parse(scores.ReadLine());
                }
                scores.Close();
            }
            catch (Exception a)
            {
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (St == 1)
            {
                x = 1;
                Random rand = new Random();

                if (epipedo2 == 1)
                {
                    s = 0;
                    en = 10;
                }

                else if (epipedo2 == 2)
                {
                    s = 10;
                    en = 50;
                }

                else
                {
                    s = 50;
                    en = 100;
                }

                pro1 = rand.Next(s, en);
                pro2 = rand.Next(s, en);
                afe1 = rand.Next(s, en);
                afe2 = rand.Next(s, en);
                pol1 = rand.Next(s, en);
                pol2 = rand.Next(s, en);
                die1 = rand.Next(s, en);
                die2 = rand.Next(s + 1, en);

                label1.Text = pro1.ToString();
                label5.Text = pro2.ToString();
                label2.Text = afe1.ToString();
                label6.Text = afe2.ToString();
                label3.Text = pol1.ToString();
                label7.Text = pol2.ToString();
                label4.Text = die1.ToString();
                label8.Text = die2.ToString();

                timer1.Enabled = true;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;

                label18.BackColor = Color.Lime;

                

                St = 2;

                button1.Text = "End Quiz";

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;

                label19.Text = null;
                label20.Text = null;
                label21.Text = null;
                label22.Text = null;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                swstes = 0;

                textBox1.Focus();

            }
            else if (St == 2)
            {
                timer1.Enabled = false;
                if (textBox1.Text == (pro1 + pro2).ToString())
                {
                    pictureBox1.ImageLocation = "tick.jpg";
                    swstes++;
                }
                else
                {
                    label19.Text = "(Correct answer: " + (pro1 + pro2).ToString()+")";
                    pictureBox1.ImageLocation = "false.jpg";
                }

                if (textBox2.Text == (afe1 - afe2).ToString())
                {
                    pictureBox2.ImageLocation = "tick.jpg";
                    swstes++;
                }
                else
                {
                    label20.Text = "(Correct answer: " + (afe1 - afe2).ToString() + ")";
                    pictureBox2.ImageLocation = "false.jpg";
                }


                if (textBox3.Text == (pol1 * pol2).ToString())
                {
                    pictureBox3.ImageLocation = "tick.jpg";
                    swstes++;
                }
                else
                {
                    label21.Text = "(Correct answer: " + (pol1 * pol2).ToString() + ")";
                    pictureBox3.ImageLocation = "false.jpg";
                }

                if (textBox4.Text == (die1 / die2).ToString())
                {
                    pictureBox4.ImageLocation = "tick.jpg";
                    swstes++;
                }
                else
                {
                    label22.Text = "(Correct answer: " + (die1 / die2).ToString() + ")";
                    pictureBox4.ImageLocation = "false.jpg";
                }

                MessageBox.Show("You got "+swstes.ToString()+" correct answers");


                class1 obj1 = new class1();
                int telxro= obj1.telikosxronos(fash, telxronos,xronos);

                class2 obj2 = new class2();
                obj2.statistika(swstes, telxro,name2,Sc,name);
               




                St = 1;
                xronos = 31;
                button1.Text = "Start a New Quiz";
                textBox1.Focus();


            }
            

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 1)
            {
                fash = 0;

                if (xronos > 15)
                {
                    label18.BackColor = Color.Lime;
                }
                else if (xronos >= 6 && xronos <= 15)
                {
                    label18.BackColor = Color.Orange;
                }
                else
                {
                    label18.BackColor = Color.Red;
                }
            }

            else
                label18.BackColor = Color.Empty;

        
           xronos -= x;
           if (xronos == 0)
           {
               label18.BackColor = Color.Empty;
               x=-1;
               fash = 1;
           }
           label18.Text = xronos + " seconds";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                 button1.PerformClick();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button1.PerformClick();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button1.PerformClick();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button1.PerformClick();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            epipedo2 = 1;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            epipedo2 = 2;
        }

        private void difficultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            epipedo2 = 3;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("~ Instructions for the Math Quiz! ~ \n \n You can change the difficulty level of the quiz any time, by just clicking on the Level tab from the Menu! After selecting the level that you want, press again the Start Quiz button (or press Enter key) and play! \n \n After starting the quiz and after entering all your answers, all you have to do is pressing the Enter key to get your results! In order to finish quickly, you can switch between the Text Boxes by pressing the Tab key! \n \n Clicking the High Scores button, a frame will appear, showing you the 5 top players ever played the quiz!  \n \n If you want to exit the Quiz, you can press the Exit button or you can go to the Application tab of the Menu and hit Exit! \n \n Have fun and good luck!");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: \n \n Panagioths Mpountourhs \n Teodoro Gomes \n Thodoris Glampedakis");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Visible = true;
            for (int i = 0; i < 5; i++)
            {
                if (Sc[i] > 0) richTextBox1.Text += (i+1)+ ") " +name[i] + " " + Sc[i].ToString() + "\n";
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      
    }
}
