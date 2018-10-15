using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication9
{
    public class class2
    {
       
        public void statistika(int swstes,int telxronos,String name,int[] Sc,String[] names)
        {
            int skor = 2000 - (telxronos * 20) - (4 - swstes) * 250 + (swstes * 20);
            
            if (swstes == 0 || skor<0)
            {
                skor = 0;
                MessageBox.Show("Your score is 0!");
            }
            else
            {
                MessageBox.Show("Your Score is : " + skor.ToString() + " !");
            }

            for (int i = 0; i < 5; i++)
            {
                if (skor > Sc[i])
                {
                    for (int j = 4; j>i; j--)
                    {
                        Sc[j] = Sc[j-1];
                        names[j] = names[j-1];
                    }
                    Sc[i] = skor;
                    names[i] = name;

                    break;
                }
            }

            try
            {
                StreamWriter score = new StreamWriter("scores.txt");
                for (int i = 0; i < 5; i++)
                {
                    score.WriteLine(names[i]);
                    score.WriteLine(Sc[i]);
                }
                score.Close();
            }
            catch (Exception a)
            {

            }

               
        }
    }
}
