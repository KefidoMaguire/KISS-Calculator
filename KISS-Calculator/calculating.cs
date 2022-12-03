using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KISS_Calculator
{

    internal class calculating
    {
        public int lastlistlength = 0;
        public string value = "";
        public string solution = "";

        public string calculaterMethod(List<string> numb)
        {
            int i = 0;
           
            foreach (var item in numb)
            {
                if (i >= lastlistlength) value = value + item;
                i++;
            }
            //I wanted to iterate through the whole list of strings and watch out for a letter like + or -
            //but the compute function, is a very powerfull tool that i found I think on stackoverflow to calculate strings (very interesting!)
            solution = new DataTable().Compute(value, null).ToString();

            lastlistlength = numb.Count;

            return solution;
        }


    }
}
