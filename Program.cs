string? input;
string? uInput;
int userInput = 0;
string? readResult = null;
string menuSelection = "";
string optionSelection = "";

string? option = null;

// Gives the user a random amount of money (from N100 to N10,000) to use.
Random amt = new Random();
int? amount = amt.Next(100, 10000 + 1);

Random pn = new Random();
int pin = pn.Next(1000, 9999 + 1);
double price = 0;
int roamDays = 0;

string balance = "";
bool bal = false;

int creditAmount = 0;
int availableBorrowFee = 0;

int? roamAmount = 0;

bool ytNight = false;
bool social = false;
bool everyDay = false;
int days = 0;
int time = 0;
int voice = 0;
string mbGb = "";
int? data = 0;
double dataAmount = 0;
double dShared = 0;
int? roamData = 0;
int dCheck = 0;

AvailableBorrowFee();

Console.Clear();
Console.WriteLine("This is a simulation of Airtel's USSD System. You are to use the amount provided to \"purchase\" data, airtime, etc ...");
Console.Write("Please wait");
await Task.Delay(1000);
Console.Write(".");
await Task.Delay(750);
Console.Write(".");
await Task.Delay(800);
Console.Write(".");

await Task.Delay(900);
Console.Clear();
Console.Write($"Hi! Before we begin, please note that you have ");
Console.ForegroundColor = ConsoleColor.Yellow; //Sets the color of the user's balance to yellow.
Console.Write($"N{amount} ");
Console.ResetColor();
Console.Write("available in your account.\n\nPin: ");
Console.ForegroundColor = ConsoleColor.DarkGreen; //Sets the color of the pin to green.
Console.Write($"{pin}");
Console.ResetColor();
Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t Liam\n");
Console.WriteLine(" ");
Console.WriteLine("Click enter to continue...");
Console.ReadLine();

do
{
    Console.Clear();
    Initial();

    input = Console.ReadLine();
    if(input != null)
    {
        menuSelection = input.ToLower();
    }
    
    //Listens for answers to the options in Initial()
    switch(menuSelection)
    {
        case "1":
            do
            {
                MyAirtelOffer();

                switch (optionSelection)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1GB/7 days for N200");

                        price = 200;
                        dataAmount = 1;
                        mbGb = "GB";
                        Data();
                        Selected();
                    break;
                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("200MB/3 days for N200");

                        price = 200;
                        dataAmount = 200;
                        mbGb = "MB"; 
                        Data();
                        Selected();
                    break;
                    
                    case "3":
                        Console.Clear();

                        Console.WriteLine("1. N200/1GB/7 days");
                        Console.WriteLine("2. N200/200MB/3 days");
                        Console.WriteLine("3. N300/1GB/1 day");
                        Console.WriteLine("4. N500/2GB/14days");
                        Console.WriteLine("5. N1000/5GB/14 days");
                        Console.WriteLine("6. N1500/3GB/30 days");
                        Console.WriteLine("7. N3000/20GB/30 days");

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {//oS2
                            optionSelection = uInput.ToLower();
                        }

                        switch (optionSelection)
                        {
                            case "1":
                                Console.Clear();

                                Console.WriteLine("N200/1GB/7 days");

                                price = 200;
                                dataAmount = 1;
                                mbGb = "GB";
                                Data();
                                Selected();
                            break;

                            case "2":
                                Console.Clear();
                                Console.WriteLine("N200/200MB/3 days");

                                price = 200;
                                dataAmount = 200;
                                mbGb = "MB";                                
                                Data();
                                Selected();
                            break;

                            case "3": 
                                Console.Clear();
                                Console.WriteLine("N300/1GB/1 day");
                                Console.WriteLine("\n\n\t\tJESUS IS KING!!!");

                                price = 300;
                                dataAmount = 1;
                                mbGb = "GB";
                                Data();                                
                                Selected();
                            break;

                            case "4":
                                Console.Clear();
                                Console.WriteLine("N500/2GB/14days");

                                price = 500;
                                dataAmount = 2;
                                mbGb = "GB";
                                Data();                                
                                Selected();
                            break;

                            case "5":
                                Console.Clear();
                                Console.WriteLine("N1000/5GB/14 days");

                                price = 1000;
                                dataAmount = 5;
                                mbGb = "GB";
                                Data();                                
                                Selected();
                            break;

                            case "6":
                                Console.Clear();
                                Console.WriteLine("N1500/3GB/30 days");

                                price = 1500;
                                dataAmount = 3;
                                mbGb = "GB";
                                Data();                               
                                Selected();
                            break;

                            case "7":
                                Console.Clear();
                                Console.WriteLine("N3000/20GB/30 days");

                                price = 3000;
                                dataAmount = 20;
                                mbGb = "GB";
                                Data();
                                Selected();
                            break;
                                
                            default:

                            break;
                        }


                    break;

                    case "4":
                        Console.Clear();
                        
                        Console.WriteLine("1. N100/12Mins + 120MB/7 days");
                        Console.WriteLine("2. N100 gives N500 for calls");
                        Console.WriteLine("3. N200/25Mins + 250MB/7 days");
                        Console.WriteLine("4. N200 gives N1000 for calls");
                        Console.WriteLine("5. N300/40Mins");

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {
                            optionSelection = uInput.ToLower();
                        }

                        switch (optionSelection)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("12Mins voice calls + 120MB for 7 days @ N100. What should happen when your bundle finishes?");
                                Console.WriteLine("1 Continue browsing from airtime");
                                Console.WriteLine("2 Stop my data");
                                Console.WriteLine("b Back");
                                Console.WriteLine();
                                readResult = Console.ReadLine();
                                option = readResult?.ToLower().Trim();
                                if (option.Contains("1"))
                                {
                                    Console.Clear();
                                    time = 12;
                                    dataAmount = 120;
                                    price = 100;
                                    days = 7;
                                    mbGb = "MB";
                                    Data();
                                    VoiceOffer();
                                }
                                else if (option.Contains("2"))
                                {
                                    Console.Clear();
                                    time = 12;
                                    dataAmount = 120;
                                    price = 100;
                                    days = 7;
                                    mbGb = "MB";
                                    Data();
                                    VoiceOffer();
                                }
                                else if(option.Contains("b"))
                                {
                                    Initial();
                                }
                            break;

                            case "2":
                                Console.Clear();
                                Console.WriteLine("N100 gives N500 for calls & SMS /30 days");
                                Console.WriteLine("1 Continue");
                                Console.WriteLine("b Back");
                                Console.WriteLine();
                                readResult = Console.ReadLine();
                                option = readResult?.ToLower().Trim();
                                if (option.Contains("1"))
                                {
                                    voice = 500;
                                    price = 100;
                                    days = 30;
                                    if (amount >= price)
                                    {    
                                        Console.Clear();
                                        Console.WriteLine($"Dear Customer, Your subscription of N{voice} calls & SMS for {days} days was for Successful.");
                                        amount -= (int)price;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
                                    }
                                    Console.ReadLine();
                                    Initial();
                                }
                                else if(option.Contains("b"))
                                {
                                    Initial();
                                }
                            break;

                            case "3": 
                                Console.Clear();
                                Console.WriteLine("25Mins voice calls + 250MB for 7 days @ N200. What should happen when your bundle finishes?");
                                Console.WriteLine("1 Continue browsing from airtime");
                                Console.WriteLine("2 Stop my data");
                                Console.WriteLine("b Back");
                                Console.WriteLine();
                                readResult = Console.ReadLine();
                                option = readResult?.ToLower().Trim();
                                if (option.Contains("1"))
                                {
                                    Console.Clear();
                                    time = 25;
                                    dataAmount = 250;
                                    price = 200;
                                    days = 7;
                                    mbGb = "MB";
                                    Data();
                                    VoiceOffer();
                                }
                                else if (option.Contains("2"))
                                {
                                    Console.Clear();
                                    time = 25;
                                    dataAmount = 250;
                                    price = 200;
                                    days = 7;
                                    mbGb = "MB";
                                    Data();
                                    VoiceOffer();
                                }
                                else if(option.Contains("b"))
                                {
                                    Initial();
                                }                                
                            break;

                            case "4":
                                Console.Clear();
                                Console.WriteLine("N200 gives N1000 for calls & SMS /30 days");
                                Console.WriteLine("1 Continue");
                                Console.WriteLine("b Back");
                                Console.WriteLine();
                                readResult = Console.ReadLine();
                                option = readResult?.ToLower().Trim();
                                if (option.Contains("1"))
                                {
                                    voice = 1000;
                                    price = 200;
                                    days = 30;
                                    if (amount >= price)
                                    {    
                                        Console.Clear();
                                        Console.WriteLine($"Dear Customer, Your subscription of N{voice} calls & SMS for {days} days was for Successful.");
                                        amount -= (int)price;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
                                    }
                                    Console.ReadLine();
                                    Initial();
                                }
                                else if(option.Contains("b"))
                                {
                                    Initial();
                                }
                            break;

                            case "5":
                                Console.Clear();
                                Console.WriteLine("40Mins voice calls + 300MB for 7 days @ N300. What should happen when your bundle finishes?");
                                Console.WriteLine("1 Continue browsing from airtime");
                                Console.WriteLine("2 Stop my data");
                                Console.WriteLine("b Back");
                                Console.WriteLine();
                                readResult = Console.ReadLine();
                                option = readResult?.ToLower().Trim();
                                if (option.Contains("1"))
                                {
                                    Console.Clear();
                                    time = 40;
                                    dataAmount = 300;
                                    price = 300;
                                    days = 7;
                                    mbGb = "MB";
                                    Data();
                                    VoiceOffer();
                                }
                                else if (option.Contains("2"))
                                {
                                    Console.Clear();
                                    time = 40;
                                    dataAmount = 300;
                                    price = 300;
                                    days = 7;
                                    mbGb = "MB";
                                    Data();
                                    VoiceOffer();
                                }
                                else if(option.Contains("b"))
                                {
                                    Initial();
                                }   
                            break;
                        }
                    break;
                    
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Recharge via Smartcash and get 100% Bonus airtime. Dial *939# to open a smartCash wallet and recharge your Airtel line.");
                        Console.WriteLine("1. Main Menu");
                        Console.WriteLine("b. Back");
                        Console.WriteLine("0 Menu");

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {
                            option = uInput.ToLower();
                        }
                        if (option.Contains("1"))
                        {
                            Initial();
                        }
                        else if (option.Contains("b"))
                        {
                            MyAirtelOffer();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                    break;
                    
                    case "b":
                        Initial();
                    break;
                    
                    default:
                    
                        MyAirtelOffer();
                    break;
                }            
                break;
            }while (optionSelection != "b");
        break;

        case "2":
            
            DataPlans();

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                option = readResult.ToLower();
                if (option != null)
                {
                    if (option.Contains("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("1 N50/40MB/Daily");
                        Console.WriteLine("2 N100/100MB/Daily");
                        Console.WriteLine("3 N200/200MB/3 Days");
                        Console.WriteLine("4 N350/350MB/7 Days");
                        Console.WriteLine("5 N500/750MB/7 Days");
                        Console.WriteLine("6 N350/1GB/Daily");
                        Console.WriteLine("7 N500/2GB/Daily");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine("\n\n\t\tJESUS IS KING!!!");

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {
                            optionSelection = uInput.ToLower();
                        }

                        if (optionSelection.Contains("1"))
                        {
                            Console.Clear();
                            Console.WriteLine("40MB for 1 day at N50. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 50;
                                dataAmount = 40;
                                mbGb = "MB";                                
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 50;
                                dataAmount = 40;
                                mbGb = "MB";                                
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("2"))
                        {
                            Console.Clear();
                            Console.WriteLine("100MB for 1 day at N100. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 100;
                                dataAmount = 100;
                                mbGb = "MB";                                
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 100;
                                dataAmount = 100;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("3"))
                        {
                            Console.Clear();
                            Console.WriteLine("200MB for 3 days at N200. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 200;
                                dataAmount = 200;
                                mbGb = "MB";                                
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 200;
                                dataAmount = 200;
                                mbGb = "MB"; 
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("4"))
                        {
                            Console.Clear();
                            Console.WriteLine("350MB for 4 days at N350. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 350;
                                dataAmount = 350;
                                mbGb = "MB";       
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 350;
                                dataAmount = 350;
                                mbGb = "MB";          
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("5"))
                        {
                            Console.Clear();
                            Console.WriteLine("750MB for 7 days at N500. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine("BAHHHHHHHH!!!");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 500;
                                dataAmount = 750;
                                mbGb = "MB";              
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 500;
                                dataAmount = 750;
                                mbGb = "MB";              
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("6"))
                        {
                            Console.Clear();
                            Console.WriteLine("1GB for 1 day at N350. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 350;
                                dataAmount = 1;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 350;
                                dataAmount = 1;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                                Console.WriteLine("Dear Customer, GET ME OUT OF HERE!!!");
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("7"))
                        {
                            Console.Clear();
                            Console.WriteLine("2GB for 1 day at N500. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 500;
                                dataAmount = 2;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 500;
                                dataAmount = 2;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                Initial();
                            }
                        }
                        else if(optionSelection.Contains("*"))
                        {

                        }
                        else if(optionSelection.Contains("b"))
                        {
                            DataPlans();
                        }
                        else if(optionSelection.Contains("0"))
                        {
                            Initial();
                        }
                    }
                    else if (option.Contains("2"))
                    {
                        DataPlans1();

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {
                            optionSelection = uInput.ToLower();
                        }

                        switch(optionSelection)
                        {
                            case "1":
                            Console.Clear();
                            Console.WriteLine("40MB for 1 day at N50. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 50;
                                dataAmount = 40;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 50;
                                dataAmount = 40;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                DataPlans1();
                            }

                            break;

                            case "2":
                            Console.Clear();
                            Console.WriteLine("100MB for 1 day at N100. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 100;
                                dataAmount = 100;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 100;
                                dataAmount = 100;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                DataPlans1();
                            }

                            break;

                            case "3":
                            Console.Clear();
                            Console.WriteLine("200MB for 3 days at N200. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 200;
                                dataAmount = 200;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 200;
                                dataAmount = 200;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                DataPlans1();
                            }

                            break;

                            case "4":
                            Console.Clear();
                            Console.WriteLine("350MB for 7 days at N350. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine("\n\n\t\tJESUS IS KING!!!");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 350;
                                dataAmount = 350;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 350;
                                dataAmount = 350;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                DataPlans1();
                            }

                            break;

                            case "5":
                            Console.Clear();
                            Console.WriteLine("500MB for 7 days at N750. What should happen when your bundle finishes?");
                            Console.WriteLine("1 Continue browsing from airtime");
                            Console.WriteLine("2 Stop my data");
                            Console.WriteLine("b Back");
                            Console.WriteLine();

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 750;
                                dataAmount = 500;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("2"))
                            {
                                price = 750;
                                dataAmount = 500;
                                mbGb = "MB";
                                Data();
                                BalCheck();
                            }
                            else if (option.Contains("b"))
                            {
                                DataPlans1();
                            }

                            break;
                            
                            case "b":
                                DataPlans();
                            break;
                        }
                    }
                    else if (option.Contains("3"))
                    {
                        Console.Clear();
                        Console.WriteLine("Monthly Bundle");
                        Console.WriteLine("1 N1500/2GB");
                        Console.WriteLine("2 N2000/3GB");
                        Console.WriteLine("3 N2500/4GB");
                        Console.WriteLine("4 N3000/8GB");
                        Console.WriteLine("5 N4000/10GB");
                        Console.WriteLine("6 N5000/13GB");
                        Console.WriteLine("7 N6000/18GB");
                        Console.WriteLine("8 N8000/25GB");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.ReadLine();

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {
                            optionSelection = uInput.ToLower();
                        }
                        if (optionSelection.Contains("1"))
                        {
                            Console.Clear();
                            Console.WriteLine("2GB @ N1500 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 1500;
                                dataAmount = 2;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("2"))
                        {
                            Console.Clear();
                            Console.WriteLine("3GB @ N2000 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 2000;
                                dataAmount = 3;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("3"))
                        {
                            Console.Clear();
                            Console.WriteLine("4GB @ N2500 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 2500;
                                dataAmount = 4;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("4"))
                        {
                            Console.Clear();
                            Console.WriteLine("8GB @ N3000 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 3000;
                                dataAmount = 8;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("5"))
                        {
                            Console.Clear();
                            Console.WriteLine("10GB @ N4000 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 4000;
                                dataAmount = 10;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("6"))
                        {
                            Console.Clear();
                            Console.WriteLine("13GB @ N5000 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 5000;
                                dataAmount = 13;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("7"))
                        {
                            Console.Clear();
                            Console.WriteLine("18GB @ N6000 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 6000;
                                dataAmount = 18;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                        if (optionSelection.Contains("8"))
                        {
                            Console.Clear();
                            Console.WriteLine("25GB @ N8000 for 30 days. Plus, 2GB YT Night. Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                             
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                ytNight = true;
                                price = 8000;
                                dataAmount = 25;
                                mbGb = "GB";
                                Data();
                                BalCheck();
                            }
                            if (option.Contains("b"))
                            {
                                DataPlans();
                            }
                            if (option.Contains("0"))
                            {
                                Initial();
                            }
                        }
                    }
                    else if (option.Contains("4"))
                    {
                        Console.Clear();
                        Console.WriteLine("1 N100/200MB");
                        Console.WriteLine("2 N300/1GB");
                        Console.WriteLine("3 N500/1.5GB");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");

                        uInput = Console.ReadLine();
                        if(uInput != null)
                        {
                            optionSelection = uInput.ToLower();
                        }
                        if (optionSelection.Contains("1"))
                        {
                            Console.Clear();
                            Console.WriteLine("200MB @ N100 for 2 days (for WhatsApp, FB, IG, YouTube and Tiktok). Select how to buy: \n1 Buy Now\nb Back\n0 Menu");

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                social = true;
                                days = 2;
                                price = 100;
                                dataAmount = 200;
                                mbGb = "MB";
                                Data();
                                SocialCheck();
                            }
                        }
                        if (optionSelection.Contains("2"))
                        {
                            Console.Clear();
                            Console.WriteLine("1GB @ N300 for 3 days (for WhatsApp, FB, IG, YouTube and Tiktok). Select how to buy: \n1 Buy Now\nb Back\n0 Menu");

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                social = true;
                                days = 3;
                                price = 300;
                                dataAmount = 1;
                                mbGb = "GB";
                                Data();
                                SocialCheck();
                            }
                        }
                        if (optionSelection.Contains("3"))
                        {
                            Console.Clear();
                            Console.WriteLine("1.5GB @ N500 for 7 days (for WhatsApp, FB, IG, YouTube and Tiktok). Select how to buy: \n1 Buy Now\nb Back\n0 Menu");

                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                social = true;
                                days = 7;
                                price = 500;
                                dataAmount = 1.5;
                                mbGb = "GB";
                                Data();
                                SocialCheck();
                            }
                        }
                        
                    }
                    else if (option.Contains("5"))
                    {
                        Console.Clear();
                        Console.WriteLine("1 N4000/15GB");
                        Console.WriteLine("2 N7500/40GB");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine("\n\n\t\tJESUS IS KING!!!");

                        uInput = Console.ReadLine();
                        if(uInput != null)                                                                        
                        {
                            optionSelection = uInput.ToLower();
                        }
                        if (optionSelection.Contains("1"))
                        {
                            Console.Clear();
                            Console.WriteLine("500MB Daily @ N4000 for 30 days (15GB).\n Select how to buy: \n1 Buy Now\nb Back\n0 Menu");

                            everyDay = true;
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 4000;
                                dataAmount = 500;
                                dShared = 15;
                                days = 30;
                                mbGb = "MB";
                                Data();
                                SocialCheck();
                            }
                        }
                        if (optionSelection.Contains("2"))
                        {
                            Console.Clear();
                            Console.WriteLine("1.3GB Daily @ N7500 for 30 days (40GB).\n Select how to buy: \n1 Buy Now\nb Back\n0 Menu");
                            
                            everyDay = true;
                            uInput = Console.ReadLine();
                            if(uInput != null)
                            {
                                option = uInput.ToLower();
                            }
                            if (option.Contains("1"))
                            {
                                price = 7500;
                                dataAmount = 1.3;
                                dShared = 40;
                                days = 30;
                                mbGb = "GB";
                                Data();
                                SocialCheck();
                            }
                        }
                    }
                    else if (option.Contains("b"))
                    {
                        Initial();
                    }
                    else if (option.Contains("0"))
                    {
                        Initial();
                    }
                    else
                    {
                        DataPlans();
                    }
                }
            }
        break;

        case "3":
            Console.Clear();

            Console.WriteLine("18GB for 30 days at N5000. After your plan finishes?");
            Console.WriteLine("1 Continue browsing from airtime");
            Console.WriteLine("2 Stop my data");
            Console.WriteLine("b Back");
            Console.WriteLine();

            readResult = Console.ReadLine();
            option = readResult? .ToLower();
            if (option!= null)
            {
                if (option.Contains("1"))
                {
                    price = 5000;
                    dataAmount = 18;
                    mbGb = "GB";
                    Data();
                    BalCheck();
                }
                else if (option.Contains("2"))
                {
                    price = 5000;
                    dataAmount = 18;
                    mbGb = "GB";
                    Data();
                    BalCheck();
                }
                else if (option.Contains("b"))
                {
                    Initial();
                }
            }
        break;

        case "4":
            Console.Clear();

            Console.WriteLine("10GB for 30 days at N3000. After your plan finishes?");
            Console.WriteLine("1 Continue browsing from airtime");
            Console.WriteLine("2 Stop my data");
            Console.WriteLine("b Back");
            Console.WriteLine("\n\n\t\tJESUS IS KING!!!");
            Console.WriteLine();

            readResult = Console.ReadLine();
            option = readResult?.ToLower();
            if (option != null)
            {
                if (option.Contains("1"))
                {
                    price = 3000;
                    dataAmount = 10;
                    mbGb = "GB";
                    Data();
                    BalCheck();
                }
                else if (option.Contains("2"))
                {
                    price = 3000;
                    dataAmount = 10;
                    mbGb = "GB";
                    Data();
                    BalCheck();
                }
                else if (option.Contains("b"))
                {
                    Initial();
                }
            }
        break;

        case "5":
            Console.Clear();

            Console.WriteLine("5GB for 30 days at N1500. What should happen when your bundle finishes?");
            Console.WriteLine("1 Continue browsing from airtime");
            Console.WriteLine("2 Stop my data");
            Console.WriteLine("b Back");
            Console.WriteLine("It's 1:22 am, why am i still here? WHYYYYY???");
            Console.WriteLine();

            readResult = Console.ReadLine();
            option = readResult?.ToLower().Trim();
            if (option != null)
            {
                if (option.Contains("1"))
                {
                    price = 1500;
                    dataAmount = 5;
                    mbGb = "GB";
                    Data();
                    BalCheck();
                }
                else if (option.Contains("2"))
                {
                    price = 1500;
                    dataAmount = 5;
                    mbGb = "GB";
                    Data();
                    BalCheck();
                }
                else if (option.Contains("b"))
                {
                    Initial();
                }
                else
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
        break;

        case "6":
            Console.Clear();
            
            Console.WriteLine("Do you currently have N500 or more? (Y/N)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                balance = readResult.ToLower();
                do
                {
                    if (balance.Contains("y") || balance.Contains("n"))
                    {
                        bal = true;
                        Bal();
                    }
                    else
                    {
                        bal = false;
                        Console.WriteLine("Please enter valid input.");
                        readResult = Console.ReadLine();
                        balance = readResult.ToLower();
                        Bal();
                    }
                }while (bal == false);
            }
        break;

        case "7":
            
            SmartDataPlans();

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                option = readResult.ToLower();
                if (option != null)
                {
                    if (option.Contains("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("(1.5GB for 1 day at  N400) When your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 400;
                            dataAmount = 1.5;
                            mbGb = "GB";
                            Data();;
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 400;
                            dataAmount = 1.5;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("2"))
                    {
                        Console.Clear();
                        Console.WriteLine("(3.5GB for 2 days at  N800) When your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine("\n\n\t\tJESUS IS KING!!!");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 800;
                            dataAmount = 3.5;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 800;
                            dataAmount = 3.5;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("3"))
                    {
                        Console.Clear();
                        Console.WriteLine("(1GB for 14 days at  N600) When your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 600;
                            dataAmount = 1;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 600;
                            dataAmount = 1;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("4"))
                    {
                        Console.Clear();
                        Console.WriteLine("1.5GB + YOUTUBE NIGHT & MUSIC for 7 days at N1000. When your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 1000;
                            dataAmount = 1.5;
                            if(amount >= price)
                            {
                                ytNight = true;
                            }
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 1000;
                            dataAmount = 1.5;
                            if(amount >= price)
                            {
                                ytNight = true;
                            }
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("5"))
                    {
                        Console.Clear();
                        Console.WriteLine("7GB + YOUTUBE NIGHT & MUSIC for 7 days at N2000. When your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 2000;
                            dataAmount = 7;
                            if(amount >= price)
                            {
                                ytNight = true;
                            }
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 2000;
                            dataAmount = 7;
                            if(amount >= price)
                            {
                                ytNight = true;
                            }
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("6"))
                    {
                        Console.Clear();
                        Console.WriteLine("25GB + YOUTUBE NIGHT & MUSIC for 7 days at N5000. When your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 5000;
                            dataAmount = 25;
                            mbGb = "GB";
                            if(amount >= price)
                            {
                                ytNight = true;
                            }
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 5000;
                            dataAmount = 25;
                            mbGb = "GB";
                            if(amount >= price)
                            {
                                ytNight = true;
                            }
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("7"))
                    {
                        Console.Clear();
                        Console.WriteLine("23GB for 30 days @ N6000 What should happen when your bundle finishes?");
                        Console.WriteLine("1 Continue browsing from airtime");
                        Console.WriteLine("2 Stop my data");
                        Console.WriteLine("b Back");
                        Console.WriteLine("0 Menu \n \n \n \n JESUS IS KING!");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 6000;
                            dataAmount = 23;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 6000;
                            dataAmount = 23;
                            mbGb = "GB";
                            Data();
                            BalCheck();
                        }
                        else if (option.Contains("b"))
                        {
                            SmartDataPlans();
                        }
                        else if (option.Contains("0"))
                        {
                            Initial();
                        }
                        else
                        {
                            SmartDataPlans();
                        }
                    }
                    else if (option.Contains("b"))
                    {
                        Initial();
                    }
                    else if (option.Contains("0"))
                    {
                        Initial();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, please try again.");
                    }
                }
            }
        break;

        case "8":
            BorrowAirtimeOrData();

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                option = readResult.ToLower();
                if (option != null)
                {
                    if (option.Contains("b"))
                    {
                        Initial();
                    }
                    else if (option.Contains("0"))
                    {
                        Console.Clear();
                        Console.WriteLine("You can borrow up to N2000 (No fee applies)");
                        Console.WriteLine("Select:");
                        Console.WriteLine("4 for N2000");
                        Console.WriteLine("5 for N1000");
                        Console.WriteLine("6 for N500");
                        Console.WriteLine("7 for N300");
                        Console.WriteLine("8 for N200");
                        Console.WriteLine("9 for N100");
                        Console.WriteLine("10 for N50");
                        Console.WriteLine("11 for N25");
                        Console.WriteLine("b Back");
                        Console.WriteLine();

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (availableBorrowFee >= 2000)
                        {
                            if (option.Contains("4"))
                            {
                                creditAmount = 2000;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("5"))
                            {
                                creditAmount = 1000;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("6"))
                            {
                                creditAmount = 500;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("7"))
                            {
                                creditAmount = 300;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("8"))
                            {
                                creditAmount = 200;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("9"))
                            {
                                creditAmount = 100;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("10"))
                            {
                                creditAmount = 50;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("11"))
                            {
                                creditAmount = 25;
                                BorrowMessage();
                                Console.ReadLine();
                            }
                            else if (option.Contains("b"))
                            {
                                BorrowAirtimeOrData();
                            }
                            else
                            {
                                BorrowAirtimeOrData();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"You are not eligible to borrow more than N{availableBorrowFee}. \nPlease add more money into your account");
                        }
                    }
                    else if (option.Contains("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("Reply with:");
                        Console.WriteLine("1 For Eligibility");
                        Console.WriteLine("2 For help");
                        Console.WriteLine("\n\n\t\tJESTS IS KING!!!");

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            Console.Clear();
                            Console.WriteLine($"Dear Customer, you can borrow up to N{availableBorrowFee} on your extra credit account");
                            Console.ReadLine();
                        }
                        else if (option.Contains("2"))
                        {
                            Console.Clear();
                            Console.WriteLine("Here's help: REMEMBER TO PAY BACK YOUR LOANS WITHIN 72 HOURS. OR ELSE...");
                            Console.WriteLine("PS: To use the pin, you'll have to \"Roam the world\".");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Wrong input, please try again");
                            Console.WriteLine("\n\n\t\tJESUS IS KING!!!");
                            Console.ReadLine();
                            BorrowAirtimeOrData();
                        }
                    }
                    else if (option.Contains("2"))
                    {
                        Console.Clear();
                        Console.WriteLine($"You can borrow up to N{availableBorrowFee} (15% Service fee applies) \nSelect:");
                        Console.WriteLine("5 for N1500");
                        Console.WriteLine("6 for N1200");
                        Console.WriteLine("7 for N1000");
                        Console.WriteLine("8 for N750");
                        Console.WriteLine("9 for N500");
                        Console.WriteLine("0 for N400");
                        Console.WriteLine("\n\nHello from the past. Today is the 3rd of March 2025, and its 21:58 right now. :)");

                        string borrowOption = "";
                        readResult = Console.ReadLine();
                        borrowOption = readResult.ToLower().Trim();

                        if (availableBorrowFee >= 1500)
                        {
                            switch(borrowOption)
                            {
                                case "5":
                                Console.Clear();
                                Console.WriteLine("You have been credited N1500");
                                creditAmount += 1500;
                                BorrowMessage();
                                Console.ReadLine();
                                break;

                                case "6":
                                Console.Clear();
                                Console.WriteLine("You have been credited N1200");
                                creditAmount += 1200;
                                BorrowMessage();
                                Console.ReadLine();                                
                                break;

                                case "7":
                                Console.Clear();
                                Console.WriteLine("You have been credited N1000");
                                creditAmount += 1000;
                                BorrowMessage();
                                Console.ReadLine();
                                break;

                                case "8":
                                Console.Clear();
                                Console.WriteLine("You have been credited N750");
                                creditAmount += 750;
                                BorrowMessage();
                                Console.ReadLine();
                                break;

                                case "9":
                                Console.Clear();
                                Console.WriteLine("You have been credited N500");
                                creditAmount += 500;
                                BorrowMessage();
                                Console.ReadLine();
                                break;

                                case "0":
                                Console.Clear();
                                Console.WriteLine("You have been credited N400");
                                creditAmount += 400;
                                BorrowMessage();
                                Console.ReadLine();
                                break;

                                default:
                                    BorrowAirtimeOrData();
                                break;                            
                            }
                        }
                        else 
                        {
                            Console.WriteLine($"You are not eligible to borrow more than N{availableBorrowFee}. \nPlease add more money into your account");
                        }
                    }
                    else if (option.Contains("3"))
                    {
                        Console.Clear();
                        Console.WriteLine("You know, there was a period where this project didn't give me a lot of stress. \n\tThat's the period where i did'nt open this IDE for a while :)");
                    }
                    else if (option.Contains("4"))
                    {
                        Console.Clear();
                        Console.WriteLine("Repay Loan");
                    }
                    else if (option.Contains("5"))
                    {
                        Console.Clear();
                        Console.WriteLine("Suspend Loan");
                    }
                }
            }
        break;

        case "9":
            RoamingPlans();

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                option = readResult.ToLower();
                if (option.Contains("1"))
                {
                    Console.Clear();
                    Console.WriteLine("Roam The World(Voice)");
                    Console.WriteLine("1 List of Countries");
                    Console.WriteLine("2 N5,000 / 7days");
                    Console.WriteLine("3 N7,000 / 30days");
                    Console.WriteLine("4 N8,000 / 30days");
                    Console.WriteLine("5 N9,000 / 30days");
                    Console.WriteLine("0 Menu");
                    Console.WriteLine("\n\n\t\tJESUS IS KING!!!");
                    Console.WriteLine();

                    readResult = Console.ReadLine();
                    option = readResult?.ToLower().Trim();
                    if (option.Contains("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("Your current balance is Rs.$balance");
                        Console.ReadLine();
                    }
                    else if (option.Contains("2"))
                    {
                        Console.Clear();
                        Console.WriteLine("Payment Option");
                        Console.WriteLine("1) Airtime");
                        Console.WriteLine("2) Smartcash + 20% more");

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 5000;
                            roamDays = 7;
                            
                            RoamVoiceCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 5000;
                            roamDays = 7;
                            // Asks user to enter pin displayed in the beginning. If they do, they get an additional 20%
                            SmartCash();  
                        }
                    }
                    else if (option.Contains("3"))
                    {
                        Console.Clear();
                        Console.WriteLine("Payment Option");
                        Console.WriteLine("1) Airtime");
                        Console.WriteLine("2) Smartcash + 20% more");

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 7000;
                            roamDays = 30;
                            
                            RoamVoiceCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 7000;
                            roamDays = 30;
                            // Asks user to enter pin displayed in the beginning. If they do, they get an additional 20%
                            SmartCash();  
                        }
                    }
                    else if (option.Contains("4"))
                    {
                        Console.Clear();
                        Console.WriteLine("Payment Option");
                        Console.WriteLine("1) Airtime");
                        Console.WriteLine("2) Smartcash + 20% more");
                        Console.WriteLine("\n\n\t\t JESUS IS KING!!!");
                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 8000;
                            roamDays = 30;
                            
                            RoamVoiceCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 8000;
                            roamDays = 30;
                            // Asks user to enter pin displayed in the beginning. If they do, they get an additional 20%
                            SmartCash();                    
                        }
                    }
                    else if (option.Contains("5"))
                    {
                        Console.Clear();
                        Console.WriteLine("Payment Option");
                        Console.WriteLine("1) Airtime");
                        Console.WriteLine("2) Smartcash + 20% more");

                        readResult = Console.ReadLine();
                        option = readResult?.ToLower().Trim();
                        if (option.Contains("1"))
                        {
                            price = 9000;
                            roamDays = 30;
                            
                            RoamVoiceCheck();
                        }
                        else if (option.Contains("2"))
                        {
                            price = 9000;
                            roamDays = 30;
                            // Asks user to enter pin displayed in the beginning. If they do, they get an additional 20%
                            SmartCash();  
                        }
                    }
                    else if (option.Contains("0"))
                    {
                        RoamingPlans();
                    }
                }
                else if (option.Contains("2"))
                {
                    Console.Clear();
                    Console.WriteLine("Roam The World(Data)\t\t (You'll need roaming Airtime to get roaming Data :) )");
                    Console.WriteLine("1 List of Countries");
                    Console.WriteLine("2 500MB/N5,000/1day");
                    Console.WriteLine("3 1GB/7,000/7days");
                    Console.WriteLine("4 3GB/N8,000/30days");
                    Console.WriteLine("5 5GB/10,000/30days");
                    Console.WriteLine("b back");
                    Console.WriteLine("0 Menu");
                    Console.WriteLine();

                    readResult = Console.ReadLine();
                    option = readResult?.ToLower().Trim();
                    if (option.Contains("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("I'M ALMOST DONE!!!");
                    }
                    else if (option.Contains("2"))
                    {
                        Console.Clear();
                        dataAmount = 500;
                        price = 5000;
                        roamDays = 1;
                        mbGb = "MB";
                        Data();
                        RoamDataCheck();
                    }
                    else if (option.Contains("3"))
                    {
                        Console.Clear();
                        dataAmount = 1;
                        price = 7000;
                        roamDays = 7;
                        mbGb = "GB";
                        Data();
                        RoamDataCheck();
                    }
                    else if (option.Contains("4"))
                    {
                        Console.Clear();
                        dataAmount = 3;
                        price = 8000;
                        roamDays = 30;
                        mbGb = "GB";
                        Data();
                        RoamDataCheck();
                    }
                    else if (option.Contains("5"))
                    {
                        Console.Clear();
                        dataAmount = 5;
                        price = 10000;
                        roamDays = 30;
                        mbGb = "GB";
                        Data();
                        RoamDataCheck();
                    }
                    else if (option.Contains("b"))
                    {
                        RoamingPlans();
                    }
                    else if (option.Contains("0"))
                    {
                        Initial();
                    }
                }
                else if (option.Contains("3"))
                {
                    Console.Clear();
                    Console.WriteLine("One Airtel(Data)\t\t (You'll need roaming Airtime to get roaming Data :) )");
                    Console.WriteLine("1 List of Countries");
                    Console.WriteLine("2 400MB/N1,000/15days");
                    Console.WriteLine("3 1GB/N2,000/30days");
                    Console.WriteLine("4 3GB/N5,000/30days");
                    Console.WriteLine("0 Menu");
                    Console.WriteLine();

                     readResult = Console.ReadLine();
                    option = readResult?.ToLower().Trim();
                    if (option.Contains("1"))
                    {
                        Console.Clear();
                        Console.WriteLine("I'M ALMOST DONE!!!");
                    }
                    else if (option.Contains("2"))
                    {
                        Console.Clear();
                        dataAmount = 400;
                        price = 1000;
                        roamDays = 15;
                        mbGb = "MB";
                        Data();
                        RoamDataCheck();
                    }
                    else if (option.Contains("3"))
                    {
                        Console.Clear();
                        dataAmount = 1;
                        price = 2000;
                        roamDays = 30;
                        mbGb = "GB";
                        Data();
                        RoamDataCheck();
                    }
                    else if (option.Contains("4"))
                    {
                        Console.Clear();
                        dataAmount = 3;
                        price = 5000;
                        roamDays = 30;
                        mbGb = "GB";
                        Data();
                        RoamDataCheck();
                    }
                }
                else if (option.Contains("4"))
                {
                    Console.Clear();
                    Console.WriteLine("Dear Customer, you will receive an Alert with your roaming data balance details shortly");
                    await Task.Delay(4000); //Delays for 4 seconds
                    Console.Clear();
                    Console.WriteLine($"Dear Customer, your roaming data balance: {roamData}MB.\n 0 Menu");
                    Console.WriteLine("\n\n\t\tJESUS IS KING!!!");
                    Console.WriteLine();

                    readResult = Console.ReadLine();
                    option = readResult?.ToLower().Trim();
                    if (option.Contains("0"))
                    {
                        RoamingPlans();
                    }
                }
                else if (option.Contains("5"))
                {
                    Console.Clear();
                    if(roamAmount > 0 || roamData > 0)
                    {
                        Console.Clear();

                        Console.WriteLine($"Dear Customer, your roaming airtime balance: N{roamAmount}.");
                        Console.WriteLine($"\tYour roaming data balance: {roamData}MB.\n");
                    }
                    else{
                        Console.Clear();

                        Console.WriteLine("Dear Customer, you do not have an active plan.");
                    }
                    Console.WriteLine("0 Menu \n");

                    readResult = Console.ReadLine();
                    option = readResult?.ToLower().Trim();
                    if (option.Contains("0"))
                    {
                        RoamingPlans();
                    }
                }
                else if (option.Contains("b"))
                {
                    RoamingPlans();
                }
                else if (option.Contains("0"))
                {
                    Initial();
                }
            }
        break;

        case "0":
            if(everyDay == false)
            {
                Console.Clear();

                Console.WriteLine($"Dear Customer, your airtime balance: N{amount}.");
                Console.WriteLine($"\t Your data balance: {data}MB.\n");
            }
            else if (everyDay == true)
            {
                Console.Clear();

                Console.WriteLine($"Dear Customer, your airtime balance: N{amount}.");
                Console.WriteLine($"\tYour data balance: {data}MB.\n");
            }
            
            if(ytNight == false)
            {
                Console.Write("YouTube Night and Music: ");
                Console.Write("Deactivated \n");
            }
            else 
            {
                Console.Write("YouTube Night and Music: ");
                Console.ForegroundColor = ConsoleColor.Green; //Turns text green
                Console.Write("Activated \n");
                Console.ResetColor();

                // Console.WriteLine("\n\n\n\n\n\t\t\t\t\tclick on \"#\" to deactivate Youtube Night");
                // readResult = Console.ReadLine();
                // option = readResult.ToLower().Trim();
                // if (option.Contains("#"))
                // {
                //     ytNight = false;
                // }
            }

            if(social == true)
            {
                Console.Write("WhatsApp, FB, IG, YouTube and Tiktok social bundle: ");
                Console.ForegroundColor = ConsoleColor.Green; //Turns text green
                Console.Write("Activated \n");
                Console.ResetColor();
            }

            Console.WriteLine("\nb. Back");
            readResult = Console.ReadLine();
            option = readResult.ToLower().Trim();
            if (option.Contains("b"))
            {
                Initial();
            }
        break;

        default:
        break;
    }
} while(menuSelection != "e");



void Initial()
{
    //First page that comes up
    Console.Clear();
    Console.Clear();

    Console.WriteLine("1 My Offer");
    Console.WriteLine("2 Data Plans");
    Console.WriteLine("3 18GB @ N5000");
    Console.WriteLine("4 10GB @ N3000");
    Console.WriteLine("5 5GB @ N1500");
    Console.WriteLine("6 2GB @ N500");
    Console.WriteLine("7 SMART DATA PLANS");
    Console.WriteLine("8 BORROW AIRTIME / DATA");
    Console.WriteLine("9 Roaming Plans");
    Console.WriteLine("0 Check balance");
    Console.WriteLine("Enter \"e\" to exit");
    Console.WriteLine();
}

void MyAirtelOffer()
{
    Console.Clear();
    Console.Clear();

    Console.WriteLine("My Airtel Offer");
    Console.WriteLine("1. N200/1GB/7 days");
    Console.WriteLine("2. N200/200MB/3 days");
    Console.WriteLine("3. MORE DATA OFFER");
    Console.WriteLine("4. VOICE OFFER");
    Console.WriteLine("5. RECHARGE OFFER");
    Console.WriteLine("b Back");
    Console.WriteLine();

    uInput = Console.ReadLine();
    if(uInput != null)
    {
        optionSelection = uInput.ToLower();
    }

}

void DataPlans()
{
    Console.Clear();
    Console.Clear();

    Console.WriteLine("1 Daily/Weekly Bundles");
    Console.WriteLine("2 Weekly Bundles");
    Console.WriteLine("3 Monthly Bundles");
    Console.WriteLine("4 Social Plans");
    Console.WriteLine("5 Everyday Plans");
    Console.WriteLine("b Back");
    Console.WriteLine("0 Menu");
    Console.WriteLine();
}

void DataPlans1()
{
    Console.Clear();
    Console.WriteLine("Weekly Bundles");
    Console.WriteLine("1 N50/40MB/Daily");
    Console.WriteLine("2 N100/100MB/Daily");
    Console.WriteLine("3 N200/200MB/3 Days");
    Console.WriteLine("4 N350/350MB/7 Days");
    Console.WriteLine("5 N500/750MB/7 Days");
    Console.WriteLine("b Back");
    Console.WriteLine("0 Menu");
    Console.WriteLine();
}

void SmartDataPlans()
{
    Console.Clear();
    Console.Clear();

    Console.WriteLine("1 N400/1.5GB");
    Console.WriteLine("2 N800/3.5GB");
    Console.WriteLine("3 N600/1GB");
    Console.WriteLine("4 N1000/1.5GB");
    Console.WriteLine("5 N2000/7GB");
    Console.WriteLine("6 N5000/25GB");
    Console.WriteLine("7 N6000/23GB");
    Console.WriteLine("b Back");
    Console.WriteLine("0 Menu");
    Console.WriteLine();
}

void BorrowAirtimeOrData()
{
    Console.Clear();

    Console.WriteLine("Airtel Extra Credit");
    Console.WriteLine("0. Borrow Talk Time/Voice Bundle");
    Console.WriteLine("1. Eligibility and Help");
    Console.WriteLine("2. Borrow Credit");
    Console.WriteLine("3. Borrow Data");
    Console.WriteLine("4. Repay Loan");
    Console.WriteLine("5. Suspend Loan");
    Console.WriteLine("b. Back");
    Console.WriteLine();
}

void RoamingPlans()
{
    Console.Clear();
    Console.Clear();

    Console.WriteLine("ROAM THE WORLD!");
    Console.WriteLine("1 Roam the world(Voice)");
    Console.WriteLine("2 Roam the world(Data)");
    Console.WriteLine("3 One Airtel(India, Airtel Africa)");
    Console.WriteLine("4 Free Incoming Call");
    Console.WriteLine("5 Check Roaming Balance");
    Console.WriteLine("b Back");
    Console.WriteLine("0 Menu");
    Console.WriteLine();
}

void VoiceOffer()
{
    if(amount >= price)
    {
        Console.Clear();
        Console.WriteLine($"Dear Customer, your subscription of {dataAmount}{mbGb} for {time} minutes through {days} days is Successful");
        amount -= (int)price;
        data += (int)dataAmount;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
    }
    Console.ReadLine();
}

void BorrowMessage()
{
    Console.Clear();
    if (creditAmount >= availableBorrowFee)
    {
        Console.WriteLine($"You have been credited N{creditAmount}");
        amount += creditAmount;
        availableBorrowFee -= creditAmount;

        Console.WriteLine("click 1 to check balance.");
        Console.WriteLine("b Back");
        readResult = Console.ReadLine();
        option = readResult.ToLower().Trim();
        if (option.Contains("1"))
        {
            BalCheck1();
        }
        else if (option.Contains("b"))
        {
            BorrowAirtimeOrData();
        }
    }
    else
    {
        Console.WriteLine($"You are not eligible to borrow N{creditAmount}.\n You can only borrow up to {availableBorrowFee}");
        Console.ReadLine();
    }
}

void BalCheck1()
{
    Console.Clear();
    Console.WriteLine($"You have N{amount} left in your account.");
    Console.WriteLine($"You can still borrow N{availableBorrowFee}.");
    Console.WriteLine("b. Back");
    readResult = Console.ReadLine();
    option = readResult.ToLower().Trim();
    if (option.Contains("b"))
    {
        BorrowAirtimeOrData();
    }
}

void Selected()
{
    Console.WriteLine("1. Activate");
    Console.WriteLine("2. Cancel");
    Console.WriteLine("b. Go Back");
    Console.WriteLine("0. Main Menu");

    uInput = Console.ReadLine();
    if (uInput != null)
    {
        optionSelection = uInput.ToLower();
    }
    switch (optionSelection)
    {
        case "1":
        Console.Clear();
        BalCheck();
        break;

        case "2":
        Console.Clear();
        Console.WriteLine("Thank you!");
        Console.ReadLine();
        break;

        case "0":
        Initial();
        break;

        case "b":
        MyAirtelOffer();
        break;
    }
} 

void Bal()
{
    if (balance.Contains("y"))
    {
        bal = true;
        if(amount >= 500)
        {
            Console.Clear();
            Console.WriteLine("You have successfully purchased 2GB of data.");
            dataAmount = 2;
            mbGb = "Gb";
            amount -= 500;
            Data();
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Dear Customer, please don't LIE again :(");

            Console.Write($"You have ");
            Console.ForegroundColor = ConsoleColor.Red; //Sets the color of the user's balance to yellow.
            Console.Write($"N{amount} ");
            Console.ResetColor();
            Console.Write("left in your account!");

            Console.ReadLine();
        }
    }
    else if (balance.Contains("n"))
    {
        Console.Clear();
        bal = true;
        Console.WriteLine("Dear customer, you do not have sufficient airtime. Recharge now.");
        Console.ReadLine();
    }
}

void BalCheck()
{
    if (amount >= price)
    {    
        Console.Clear();
        Console.WriteLine($"Dear Customer, Your subscription of {dataAmount}{mbGb} was Successful.");
        amount -= (int)price;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
    }
    Console.ReadLine();
    Initial();
}

void SocialCheck()
{
    if(everyDay == false)
    {
        if (amount >= price)
        {    
            Console.Clear();
            Console.WriteLine($"Dear Customer, Your subscription of {dataAmount}{mbGb} for {days} days was Successful.");
            amount -= (int)price;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
        }
        Console.ReadLine();
        Initial();
    }
    else if (everyDay == true)
    {
        if (amount >= price)
        {    
            Console.Clear();
            Console.WriteLine($"Dear Customer, Your subscription of {dShared}GB for {days} days was Successful.\n You will receive {dataAmount}{mbGb} daily.");
            amount -= (int)price;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
        }
        Console.ReadLine();
        Initial();
    }
}

void RoamVoiceCheck()
{
    if (amount >= price)
    {    
        Console.Clear();
        Console.WriteLine($"Dear Customer, Your subscription of N{price} for {roamDays} days was for Successful.");
        amount -= (int)price;
        roamAmount += (int)price;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
    }
    Console.ReadLine();
    Initial();
}

void RoamDataCheck()
{
    if(roamAmount >= price)
    {
        Console.Clear();
        Console.WriteLine($"Dear Customer, your subscription of {dataAmount}{mbGb} for {roamDays} is Successful");
        roamAmount -= (int)price;
        roamData += (int)dataAmount;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Dear Customer, u d'nt hv sffcnt airtm to cmplt ths trnsctn. U need N{price - roamAmount} more");
        Console.WriteLine("I know, right? yeesh.");
    }
    Console.ReadLine();
}

void SmartCash()
{
    Console.Clear();
    Console.WriteLine("Please enter 4 digit pin");
    
    // The app displayed a pin in the beginning. If the user enters the pin here, they get an additional 20%
    readResult = Console.ReadLine();
    option = readResult?.Trim();
    if (int.TryParse(option, out userInput))//Converts string to integer
    {
        if (userInput == pin)
        {
            if(amount >= price)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ACCEPTED");
                Console.ResetColor();
                Console.WriteLine("please wait...");
                Thread.Sleep(2000); //Delays for 2 seconds
                Console.Clear();
                Console.WriteLine("You have been given an additional 20%...");
                Thread.Sleep(2000);

                price = price * 1.2; //Adds 20% to the product
                 
                Console.Clear();
                Console.WriteLine($"Dear Customer, Your subscription of N{price} for {roamDays} days was for Successful. \n Press enter to continue...");
                amount -= (int)price;
                roamAmount += (int)price;
                
                Console.ReadLine();
                Initial();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Dear customer, you do not have sufficient airtime, you need N{price - amount} more to complete this transaction.");
                Console.ReadLine();
                Initial();
            }                               
        }      
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect Pin!");
            Console.ResetColor();
            Console.ReadLine();
            if (userInput == pin)
            {
                SmartCash();
            }
            else
            {
                RoamingPlans();
            }
        } 
    }
    else
    {
        Console.WriteLine("Invalid input, please enter a valid number.");
        Console.ReadLine();
        if (userInput == pin)
        {
            SmartCash();
        }
        else
        {
            RoamingPlans();
        }
    }
}

void AvailableBorrowFee()
{
    if (amount <= 100)
    {
        availableBorrowFee += 1000;
    }
    if(amount > 1000)
    {
        availableBorrowFee += 2000;
    }
    else
    {
        availableBorrowFee += 1000;
    }
}

void GbMb()
{
    if (mbGb.Contains("MB"))
    {
        dCheck = 0;
    }
    else if (mbGb.Contains("GB"))
    {
        dCheck = 1;
    }
}

void Data()
{
    //Converts GB to MB
    GbMb();

    if (dCheck == 1)
    {    
        data += (int)dataAmount * 1000;
    }
    else if (dCheck == 0)
    {
        data += (int)dataAmount;
    }
}



 // NOTES
                
// string? option (warning message has been set to silent)
// [*.cs]

// # CS8602: Dereference of a possibly null reference.
// dotnet_diagnostic.CS8602.severity = silent