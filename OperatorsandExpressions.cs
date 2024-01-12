using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OperatorsandExpressions
{
    public class OperatorsandExpressions
    {
        public int a { get; set; } = 10;
        public int b { get; set; } = 20;

        //Arithmetic Operators

        //Addation Operation
        public int AddArthmaticOperation()
        {
            return a + b;
        }

        //Subtraction Operation
        public int SubArthmaticOperation()
        { 
            return a - b;
        }

        //Mutiplation Operation
        public int MultiplicationArthmaticOperation()
        {
            return b * a;
        }

        //Division Operation
        public int DivisionOperation()
        {
            return a / b;
        }

        //Mod Operation
        public int ModOperation() { return a % b;}

    }
}
