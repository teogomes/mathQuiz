using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public class class1
    {

        public int telikosxronos(int fash, int telxronos,int xronos)
        {
            if (fash == 1)
            {
                telxronos = 30 + xronos;
                MessageBox.Show("You overcame the time and you finished in " + telxronos + " seconds");
            }
            else
            {
                telxronos = 30 - xronos;
                MessageBox.Show("You finished in " + telxronos + " seconds");
            }

            return telxronos;
        }
        
    }
}
