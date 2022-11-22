﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleAppMain
{
    public class LanguageOptions
    {
     //   public string SelectedOption = "";

        public void welcome(string message)
        {
            if(message == "1")
            {
                Console.WriteLine("Welcome To Our ATM");
                Console.WriteLine("Please Insert Your Card Number: ");
            }else if(message == "2")
            {
                Console.WriteLine("Nnọọ na ATM anyị");
                Console.WriteLine("Biko tinye nọmba kaadị gị: ");
            }
            else if (message == "3")
            {
                Console.WriteLine("I dy welcome you for this ATM");
                Console.WriteLine("Abeg try put your card number: ");
            }
            else
            {
                Console.WriteLine("Welcome To Our ATM");
                Console.WriteLine("Please Insert Your Card Number: ");
            }

        }

        public void cardNotRecognized(string message)
        {
            if (message == "1")
            {
                Console.WriteLine("Card Not recognized try again");
            }
            else if (message == "2")
            {
                Console.WriteLine("Achọpụtaghị kaadị nwaa ọzọ");
            }
            else if (message == "3")
            {
                Console.WriteLine("This your card number no correct, abeg put am again");
            }
            else
            {

                Console.WriteLine("Card Not recognized try again");
            }

        }

       
        public void InsertPinNumber(string message)
        {
            if (message == "1")
            {
                Console.WriteLine("Please Provide your Pin Number: ");
            }
            else if (message == "2")
            {
                Console.WriteLine("Biko nye nọmba pin gị: ");
            }
            else if (message == "3")
            {
                Console.WriteLine("This your card number no correct, abeg put am again");
            }
            else
            {
                Console.WriteLine("Please Provide your Pin Number: ");
            }
        }

        public void cardPinNotRecognized(string message)
        {
            if (message == "1")
            {
                Console.WriteLine("Card Pin Incorrect try again");
            }
            else if (message == "2")
            {
                Console.WriteLine("Ntụtụ kaadị ezighi ezi nwaa ọzọ");
            }
            else if (message == "3")
            {
                Console.WriteLine("This your pin no correct, abeg put am again");
            }
            else
            {
                Console.WriteLine("Card Pin Incorrect try again");
            }

        }

        public void WelcomeUser(string message, string FullName )
        {
            if (message == "1")
            {
                Console.WriteLine("Welcome " + FullName);
            }
            else if (message == "2")
            {
                Console.WriteLine("Nnọọ " + FullName);
            }
            else if (message == "3")
            {
                Console.WriteLine("I dy hail you " + FullName);
            }
            else
            {

                Console.WriteLine("Welcome " + FullName);
            }
        }

        public void DisplayBalance(string message,double balance )
        {

            if (message == "1")
            {
                Console.WriteLine("Your Current Balance is " + balance);
            }
            else if (message == "2")
            {
                Console.WriteLine("Balance gị ugbu a bụ " + balance);
            }
            else if (message == "3")
            {
                Console.WriteLine("Your balance na " + balance);
            }
            else
            {
                Console.WriteLine("Your Current Balance is " + balance);
            }
        }

        public void TransferInsertCard(string message)
        {

            if (message == "1")
            {
                Console.WriteLine("Please Insert Your Card Number Of Person you would like to transfer to: ");
            }
            else if (message == "2")
            {
                Console.WriteLine("Biko tinye nọmba kaadị gị nke onye ịchọrọ ibufe na ya: ");
            }
            else if (message == "3")
            {
                Console.WriteLine("Abeg put card number of person way you wan send money give: ");
            }
            else
            {
                Console.WriteLine("Please Insert Your Card Number Of Person you would like to transfer to: ");
            }
        }

        public void HaveANiceDay(string message)
        {

            if (message == "1")
            {
                Console.WriteLine("Thank you have a nice day");
            }
            else if (message == "2")
            {
                Console.WriteLine("Daalụ nwere ọmarịcha ụbọchị");
            }
            else if (message == "3")
            {
                Console.WriteLine("E go be nah ");
            }
            else
            {
                Console.WriteLine("Thank you have a nice day");
            }
        }

        
    }
}
