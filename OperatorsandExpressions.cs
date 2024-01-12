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

        //*************************************ARITHMATIC OPERATION IN C# BY SARDAR MUDASSAR ALI KHAN*****************************************
        //Arithmetic Operators In C# Programming

        /// <summary>
        /// Addation Operation
        /// </summary>
        /// <returns></returns>
        public int AddArthmaticOperation()
        {
            return a + b;
        }

        /// <summary>
        /// Subtraction Operation
        /// </summary>
        /// <returns></returns>
        public int SubArthmaticOperation()
        { 
            return a - b;
        }

        /// <summary>
        /// Mutiplation Operation
        /// </summary>
        /// <returns></returns>
        public int MultiplicationArthmaticOperation()
        {
            return b * a;
        }

        /// <summary>
        /// Division Operation
        /// </summary>
        /// <returns></returns>
        public int DivisionOperation()
        {
            return a / b;
        }

        /// <summary>
        /// Mod Operation
        /// </summary>
        /// <returns></returns>
        public int ModOperation() { return a % b;}

        //*************************************COMPARISION OPERATION IN C# BY SARDAR MUDASSAR ALI KHAN*****************************************
        //Comparison Operators In C# Programming
        /// <summary>
        /// IsEqual O
        /// </summary>
        /// <returns></returns>
        public bool IsEqual()
        {
            return (a == b);
        }

        /// <summary>
        /// IsNotEqual
        /// </summary>
        /// <returns></returns>
        public bool IsNotEqual()
        {
            return (a != b);
        }

        /// <summary>
        /// LessThen
        /// </summary>
        /// <returns></returns>
        public bool LessThan()
        {
            return a < b;
        }

        /// <summary>
        /// GraterThen
        /// </summary>
        /// <returns></returns>
        public bool GreaterThan()
        {
            return a > b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool LessThanOrEqualTo()
        {
            return a <= b;
        }

        /// <summary>
        /// GreaterThanOrEqualTo
        /// </summary>
        /// <returns></returns>
        public bool GreaterThanOrEqualTo()
        {
            return a >= b;
        }

        ///***********************************LOGICAL OPERATIONS IN C# BY SARDAR MUDASSAR ALI KHAN***********************************
        //Logical Operators in C# Programming
        public bool Condation1 = true;
        public bool Condation2 = false;
        /// <summary>
        /// NotEquals
        /// </summary>
        /// <returns></returns>
        public bool AndOperation()
        {
            return Condation1 && Condation2;
        }

        /// <summary>
        /// OrOperation
        /// </summary>
        /// <returns></returns>
        public bool OrOperation()
        {
            return Condation1 || Condation2;
        }

        public bool NotOperation()
        {
            return !Condation1 || Condation2;
        }

        //*****************************************ASSIGNMENT OPERATORS IN C#********************************************

        /// <summary>
        /// AssignmentOperators
        /// </summary>
        /// <returns></returns>
        public int AssignmentOperators()
        {
            return a = 100;
        }

        /// <summary>
        /// PulusEqualOperators
        /// </summary>
        /// <returns></returns>

        public int PulusEqualOperators()
        {
            return b += 100;
        }

        /// <summary>
        /// MultiplicationOperators
        /// </summary>
        /// <returns></returns>
        public int MultiplicationOperators()
        {
            return a *=a * b;
        }

        /// <summary>
        /// DivisionOperators
        /// </summary>
        /// <returns></returns>
        public int DivisionOperators()
        {
            return b /=a / b;
        }

        public int ModulusEqualOperators()
        {
            return a %=10;
        }

        /// <summary>
        /// MultiplicationEqualOperators
        /// </summary>
        /// <returns></returns>
        public int MultiplicationEqualOperators()
        {
            return a *=b;
        }

        /// <summary>
        /// DivisionEqualOperators
        /// </summary>
        /// <returns></returns>
        public int DivisionEqualOperators()
        {
            return a %=10;
        }

        //******************************************EXPRESSIONS IN C# PROGRAMMING*********************

        /// <summary>
        /// ExpressionsInCSharp
        /// </summary>
        /// <returns></returns>
        public int ExpressionsInCSharp()
        {
            return (a*b) + (b*a);
        }
    }
}
