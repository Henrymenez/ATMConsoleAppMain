namespace ATMConsoleAppMain
{
    public class CardHolder
    {
        private string CardNumber { get; set; }
        private int CardPin { get; set; }
        private string FullName { get; set; }
        private double UserBalanace { get; set; }
        public CardHolder(string CardNumber, int CardPin, string FullName, double UserBalanace)
        {
            CardNumber = CardNumber;
            CardPin = CardPin;
            FullName = FullName;
            UserBalanace = UserBalanace;
        }

        public int GetCardPin()
        { return CardPin; }

        public double GetUserBalance()
        {
            return UserBalanace;
        }
        public string GetCardNumber()
        { return CardNumber; }

        public string GetFullName() { return FullName; }
        public void deposit(CardHolder CurrentUser)
        {
            Console.WriteLine("How much would you like to deposit: ");
            double deposit = Double.Parse(Console.ReadLine());
            CurrentUser.UserBalanace = deposit + CurrentUser.UserBalanace;
            Console.WriteLine("Thank you, your new balnace is: " + CurrentUser.UserBalanace);

        }

        public void withdraw(CardHolder CurrentUser)
        {
            Console.WriteLine("How much would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            if (withdrawal > CurrentUser.UserBalanace)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                double NewBalance = CurrentUser.UserBalanace - withdrawal;
                CurrentUser.UserBalanace = NewBalance;
                Console.WriteLine("Thank you for withdrawing " + withdrawal);
            }

        }

        public void transfer(CardHolder CurrentUser, CardHolder TransferUser)
        {
            Console.WriteLine("How much would you like to transfer: ");
            double transfer = Double.Parse(Console.ReadLine());
            if (transfer > CurrentUser.UserBalanace)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {

                double NewBalance = CurrentUser.UserBalanace - transfer;
                double TransferUserNewBalance = TransferUser.UserBalanace + transfer;

                CurrentUser.UserBalanace = NewBalance;
                TransferUser.UserBalanace = TransferUserNewBalance;
                Console.WriteLine("Thank you for Transfering " + transfer + " to " + TransferUser.FullName);
                Console.WriteLine("Your Current Balance is " + CurrentUser.UserBalanace);

            }
        }
    }
    public class ATMFunctionalities
    {
        public void printOptions(string language)
        {

            if (language == "1")
            {
                Console.WriteLine("Please choose from one of these following options..!");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");
            }
            else if (language == "2")
            {
                Console.WriteLine("Biko họrọ n'otu n'ime nhọrọ ndị a..!");
                Console.WriteLine("1. Nkwụnye ego");
                Console.WriteLine("2. Wepụ");
                Console.WriteLine("3. Gosi Balance");
                Console.WriteLine("4. Nyefee Ego");
                Console.WriteLine("5. Ụzọ ọpụpụ");
            }else if(language == "3")
            {
                Console.WriteLine("Abeg Select one of these options..!");
                Console.WriteLine("1. put money");
                Console.WriteLine("2.  commot money");
                Console.WriteLine("3. you wan see balance");
                Console.WriteLine("4. send money give person");
                Console.WriteLine("5. Exit");
            }
            else
            {
                Console.WriteLine("Please choose from one of these following options..!");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");
            }
        }

        public void Run()
        {
            List<CardHolder> CardHolders = new List<CardHolder>();
            CardHolders.Add(new CardHolder("45327722", 1234, "John Jonas", 150.32));
            CardHolders.Add(new CardHolder("7657725", 4254, "Matt Smith", 700.12));
            CardHolders.Add(new CardHolder("89327711", 2458, "Shawn Wallas", 54.32));
            Console.WriteLine("Select Language Option");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Igbo");
             Console.WriteLine("3. pidgin");
            string Language = Console.ReadLine();

            LanguageOptions languageOptions = new LanguageOptions();
            languageOptions.welcome(Language);


            string debitCardNumber = "";
            CardHolder CurrentUser;

            while (true)
            {
                try
                {
                    debitCardNumber = Console.ReadLine();
                    //check against db
                    CurrentUser = CardHolders.FirstOrDefault(a => a.GetCardNumber() == debitCardNumber);
                    if (CurrentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        languageOptions.cardNotRecognized(Language);
                    }
                }
                catch
                {
                    languageOptions.cardNotRecognized(Language);
                }
            }
            languageOptions.InsertPinNumber(Language);
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    //check against db

                    if (CurrentUser.GetCardPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        languageOptions.cardPinNotRecognized(Language);
                    }
                }
                catch
                {
                    languageOptions.cardPinNotRecognized(Language);
                }
            }

            languageOptions.WelcomeUser(Language, CurrentUser.GetFullName());
            int option = 0;

            do
            {
                printOptions(Language);
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {

                }
                if (option == 1)
                {
                    CurrentUser.deposit(CurrentUser);
                }
                else if (option == 2)
                {
                    CurrentUser.withdraw(CurrentUser);
                }
                else if (option == 3)
                {
                    languageOptions.DisplayBalance(Language, CurrentUser.GetUserBalance());
                }
                else if (option == 4)
                {
                    languageOptions.TransferInsertCard(Language);
                    string TransferUserDebitCardNumber = "";
                    CardHolder TransferUser;

                    while (true)
                    {
                        try
                        {
                            TransferUserDebitCardNumber = Console.ReadLine();
                            //check against db
                            TransferUser = CardHolders.FirstOrDefault(a => a.GetCardNumber() == TransferUserDebitCardNumber);
                            if (TransferUser != null)
                            {
                                break;
                            }
                            else
                            {
                                languageOptions.cardNotRecognized(Language);
                            }
                        }
                        catch
                        {
                            languageOptions.cardNotRecognized(Language);
                        }
                    }
                    CurrentUser.transfer(CurrentUser, TransferUser);
                }
                else if (option == 5)
                {
                    break;
                }

            } while (option != 5);
            languageOptions.HaveANiceDay(Language);
        }
    }

}
