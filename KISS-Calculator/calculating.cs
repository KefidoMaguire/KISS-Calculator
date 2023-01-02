using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KISS_Calculator
{
    
    class calculating
    {
        

       public string cal(string result)
       {
            Calculator calculatorForm = new Calculator();

            string solution = new DataTable().Compute(result, null).ToString();


            return solution;
       }


    }
}
