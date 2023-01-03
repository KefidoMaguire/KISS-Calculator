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
        
        /// <summary>
        /// calculates a given string
        /// </summary>
        /// <param name="result"></param>
        /// <returns>solution</returns>
       public string cal(string result)
       {
            //Calls object
            Calculator calculatorForm = new Calculator();
            //calculates a string
            string solution = new DataTable().Compute(result, null).ToString();
            //returns solution
            return solution;
       }


    }
}
