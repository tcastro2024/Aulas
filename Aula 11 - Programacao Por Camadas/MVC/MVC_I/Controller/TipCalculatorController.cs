/*
*	<copyright file="TipCalculatorController.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/15/2020 11:28:08 AM</date>
*	<description>MVC: Controller Entity</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_I.Controller
{
    /// <summary>
    /// Controller
    /// </summary>
    class TipCalculatorController
    {
        // The TipCalculatorController class brings together 
        /// the display and the tip or model classes
        /// I use the constructor to instantiate the Display.
        /// Instantiating the Display calls its constructor
        /// which calls the Get input method
        /// Once the input is entered I can instantiate
        /// the Gorjeta class and pass the values from the 
        /// Display class
        /// 
        private Model.Gorjeta tip;        //model
        private View.Display display;    //view


        /// <summary>
        /// Equivale ao nosso Main()
        /// </summary>
        public TipCalculatorController()
        {
            //create a View (display) instance
            display = new View.Display();
            //create a Model (Gorjeta) instance
            tip = new Model.Gorjeta(display.Amt, display.Percentage);
            //Get Values and Instanciate the Model instance
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            //Show results (trigger to View)
            display.ShowTipandTotal();
        }
    }
}
