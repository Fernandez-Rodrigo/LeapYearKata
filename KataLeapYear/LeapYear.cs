using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLeapYear
{
    public class LeapYear
    {


        public bool IsLeap(int year)
        {
            /* if(year % 4 != 0 || year <= 0)
             {
                 return false;
             }
             else if(year % 400 != 0)
             {
                 return false;
             }
             else
             {
                 return true;
             }*/
            if (year >= 0)
            { 
               if(year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
               {
                return true;
               }
            }
            return false;
   
        }

    }
}
