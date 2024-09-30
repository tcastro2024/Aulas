using System;

namespace Aula_2___Basico
{
    public class Student
    {
        #region STATE | ATRIBUTES | VARIABLES

        static string course;           //private
        public static string name;      //public
        public static double average;   //public
        public static int age;          //public

        #endregion

        #region Behavior | METHODS 

        public static string GetCourse()
        {
            return "LEIM";
        }

        #endregion
    }
}