public class cardHolder
{
    String cardId;
    int PIN;
    String fName;
    String lName;
    double balance;

    public cardHolder(string cardId, int pIN, string fName, string lName, double balance)
    {
        this.cardId = cardId;
        PIN = pIN;
        this.fName = fName;
        this.lName = lName;
        this.balance = balance;
    }

    public String getCardId()
    {
        return cardId;  
    }
    public int getPIN()
    {
        return PIN;
    }

    public String getFName()
    {
        return fName;
    }

    public String getLName()
    {
        return lName;
    }

    public double getBalance()
    {
        return balance; 
    }

    public void setCardId(String newCardId)
    {
        cardId = newCardId;
    }
    public void setPIN(int newPIN)
    {
        PIN = newPIN;   
    }

    public void setFName(String newFName)
    {
        fName = newFName;   
    }

    public void setLName(String newLName)
    {
        lName = newLName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Show balance");
            Console.WriteLine("4.Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit: ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your money your balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw: ");
            double withdrawl = Double.Parse(Console.ReadLine());
            if(currentUser.getBalance() < withdrawl)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawl);
                Console.WriteLine("Thank you. Your balance is: " + currentUser.getBalance());
                Console.WriteLine("You're good to go! Thank you :)");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance is: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("11111", 123, "Abdo", "Hosny", 150.31));
        cardHolders.Add(new cardHolder("22222", 456, "Omar", "Muhammed", 321.13));
        cardHolders.Add(new cardHolder("33333", 789, "Yasser", "Ali", 105.59));
        cardHolders.Add(new cardHolder("44444", 147, "Youssef", "Ayman", 90));
        cardHolders.Add(new cardHolder("55555", 258, "Eslam", "Ibrahim", 150.31));

        Console.WriteLine("Welcome to simple ATM");
        Console.WriteLine("Please insert your debit card: ");

        String debitCardId = "";
        cardHolder currentUser;
        while(true)
        {
            try 
            { 
                debitCardId = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardId == debitCardId);
                if (currentUser != null) break;
                else
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again");
            }
        }

        Console.WriteLine("Please enter your PIN: ");
        int userPIN = 0;
        while (true)
        {
            try
            {
                userPIN = int.Parse(Console.ReadLine());
                if (currentUser.getPIN() == userPIN) break;
                else
                {
                    Console.WriteLine("Incorrect PIN. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect PIN. Please try again");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFName() + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
            if (option == 1) deposit(currentUser);
            else if (option == 2) withdraw(currentUser);
            else if (option == 3) balance(currentUser);
            else if (option == 4) break;
            else option = 0;
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day :)");
    }

}