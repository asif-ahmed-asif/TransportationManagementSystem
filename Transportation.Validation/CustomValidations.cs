using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation.Validation
{
    internal static class CustomValidations
    {
        internal static bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }
        
        internal static bool ValidPhoneNumber(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsNumber);
        }
        
        internal static bool ValidSalary(string sal)
        {
            try
            {
                float salary = float.Parse(sal);
            }
            catch(FormatException e)
            {
                //MessageBox.Show(e.ToString());
                return false;
            }

            return true;
            //return sal.All(char.IsLetter);
        }
    }
}
