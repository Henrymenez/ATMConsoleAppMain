namespace ATMConsoleAppMain
{
    public class LanguageOptions
    {
        //   public string SelectedOption = "";

        public void welcome(string message)
        {
            if (message == "1")
            {
                Console.WriteLine("Welcome To Our ATM");
                Console.WriteLine("Please Insert Your Card Number: ");
            }
            else if (message == "2")
            {
                Console.WriteLine("Nnoo na ATM anyi");
                Console.WriteLine("Biko tinye nomba kaadi gi: ");
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
                Console.WriteLine("Achoputaghi kaadi nwaa ozo");
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
                Console.WriteLine("Biko nye nomba pin gi: ");
            }
            else if (message == "3")
            {
                Console.WriteLine("Abeg try put your card pin: ");
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
                Console.WriteLine("Ntutu kaadi ezighi ezi nwaa ozo");
            }
            else if (message == "3")
            {
                Console.WriteLine("This your card pin no correct, abeg put am again");
            }
            else
            {
                Console.WriteLine("Card Pin Incorrect try again");
            }

        }

        public void WelcomeUser(string message, string FullName)
        {
            if (message == "1")
            {
                Console.WriteLine("Welcome " + FullName);
            }
            else if (message == "2")
            {
                Console.WriteLine("Nnoo " + FullName);
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

        public void DisplayBalance(string message, double balance)
        {

            if (message == "1")
            {
                Console.WriteLine("Your Current Balance is " + balance);
            }
            else if (message == "2")
            {
                Console.WriteLine("Balance gi ugbu a bu " + balance);
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
                Console.WriteLine("Biko tinye nomba kaadi gi nke onye ichoro ibufe na ya: ");
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
                Console.WriteLine("Daalu nwere omaricha ubochi");
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

        public void LikeToDeposit(string message)
        {
            if (message == "1")
            {
                Console.WriteLine("How much would you like to deposit: ");
            }
            else if (message == "2")
            {
                Console.WriteLine("Ego ole ka ichoro itenye");
            }
            else if (message == "3")
            {
                Console.WriteLine("How Much you go like deposit: ");
            }
            else
            {
                Console.WriteLine("How much would you like to deposit: ");
            }
        }
        public void ThanksToDeposit(string message, double balance)
        {
            if (message == "1")
            {
                Console.WriteLine("Thank you, your new balnace is: " + balance);
            }
            else if (message == "2")
            {
                Console.WriteLine("Daalụ, Balance gi ugbu a bu   " + balance);
            }
            else if (message == "3")
            {
                Console.WriteLine("Na you do pass, your new balance na: " + balance);
            }
            else
            {
                Console.WriteLine("Thank you, your new balnace is: " + balance);
            }
        }

        public void LikeToWithdraw(string message)
        {

            if (message == "1")
            {
                Console.WriteLine("How much would you like to withdraw: ");
            }
            else if (message == "2")
            {
                Console.WriteLine("Ego ole ka ichoro iwepu: ");
            }
            else if (message == "3")
            {
                Console.WriteLine("How Much you go like withdraw: ");
            }
            else
            {
                Console.WriteLine("How much would you like to withdraw: ");
            }
        }

        public void NotEnoughBalance(string message)
        {
            if (message == "1")
            {
                Console.WriteLine("Insufficient balance");
            }
            else if (message == "2")
            {
                Console.WriteLine("Ego gi perempe");
            }
            else if (message == "3")
            {
                Console.WriteLine("Your balance no reach, you fit no too get money like that");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public void ThanksForWithdrawing(string message, double amount)
        {
            if (message == "1")
            {
                Console.WriteLine("Thank you for withdrawing : " + amount);
            }
            else if (message == "2")
            {
                Console.WriteLine("Daalụ, make i withdraw " + amount);
            }
            else if (message == "3")
            {
                Console.WriteLine("i hail you as you withdraw : " + amount);
            }
            else
            {
                Console.WriteLine("Thank you for withdrawing : " + amount);
            }
        }


        public void LikeToTransfer(string message)
        {

            if (message == "1")
            {
                Console.WriteLine("How much would you like to Transfer: ");
            }
            else if (message == "2")
            {
                Console.WriteLine("Ego ole ka ichoro iyefee: ");
            }
            else if (message == "3")
            {
                Console.WriteLine("How Much you go like Transfer: ");
            }
            else
            {
                Console.WriteLine("How much would you like to Transfer: ");
            }
        }
        public void ThankForTransfer(string message,double transfer, string fullName)
        {

            if (message == "1")
            {
                Console.WriteLine("Thank you for Transfering " + transfer + " to " + fullName);
            }
            else if (message == "2")
            {
                Console.WriteLine("Daalu maka  " + transfer + " ibufere " + fullName);
            }
            else if (message == "3")
            {
                Console.WriteLine("Thank you as you Transfer " + transfer + " give " + fullName);
            }
            else
            {
                Console.WriteLine("Thank you for Transfering " + transfer + " to " + fullName);
            }
        }

        public void exceptionMessage(string message)
        {
            if (message == "1")
            {
                  Console.WriteLine("Something went wrong. Please try again");
            }
            else if (message == "2")
            {
                 Console.WriteLine("O nwere ihe adighi mma. Biko nwaa ozo");
            }
            else if (message == "3")
            {
                  Console.WriteLine("Something happen. Abeg try again");
            }
            else
            {
                 Console.WriteLine("Something went wrong. Please try again");
            }
        }
    }
}
