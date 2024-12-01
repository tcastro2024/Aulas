/*
*	<copyright file="AnonymousMethods.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>tcastro</author>
*   <date>02/12/2024 16:00:23 PM</date>
*	<description>
*	Adaptado de:
*	https://www.tutorialspoint.com/csharp/csharp_anonymous_methods.htm
*	</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___Expressoes_Lambda_e_LINQ
{
    /// <summary>
    /// Purpose:
    /// Created by: tcastro
    /// Created on: 02/12/2024 16:00:23 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class TestDelegate
    {
        static int num = 10;

        int x;

        public int X
        {
            //get { return x; }
            get => x;
            //set { x = value; }
            set => x = value;
        }

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static int getNum()
        {
            return num;
        }
    }
}
