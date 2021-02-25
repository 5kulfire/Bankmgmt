using System;
using System.Collections.Generic;
using System.Linq;

namespace AS_W2021_991555817
{
    class Program
    {
        class ClientAcc
        {
           public string[] clientinf = { "Frank Smith", "4377", "128 North Ave", "786546389", "franks@eg.com", "Personal account" }; //name, pin, address, phone, email, account type

            public void info()
            {
                Console.WriteLine("Name: {0}", clientinf[0]);
                Console.WriteLine("Address: {0}", clientinf[2]);
                Console.WriteLine("Phone number: {0}", clientinf[3]);
                Console.WriteLine("Email: {0}", clientinf[4]);
                Console.WriteLine("Account Type: {0}", clientinf[5]);
            }
            public void editname(string name)
            {
                var clientName = (from nm in clientinf
                                  select nm).ElementAt(0);
                clientName = name;
                clientinf[0] = clientName;
                Console.WriteLine("\nSuccessfully updated.\n");
            }
            public void editpin(string pin)
            {
                var clientpin = (from nm in clientinf
                                  select nm).ElementAt(1);
                clientpin = pin;
                clientinf[1] = clientpin;
                Console.WriteLine("\nSuccessfully updated.\n");
            }
            public void editaddr(string addr)
            {
                var clientaddr = (from nm in clientinf
                                  select nm).ElementAt(2);
                clientaddr = addr;
                clientinf[2] = clientaddr;
                Console.WriteLine("\nSuccessfully updated.\n");
            }
            public void editph(string ph)
            {
                var clientph = (from nm in clientinf
                                  select nm).ElementAt(3);
                clientph = ph;
                clientinf[3] = clientph;
                Console.WriteLine("\nSuccessfully updated.\n");
            }
            public void editmail(string mail)
            {
                var clientmail = (from nm in clientinf
                                  select nm).ElementAt(4);
                clientmail = mail;
                clientinf[4] = clientmail;
                Console.WriteLine("\nSuccessfully updated.\n");
            }
            public void editType(string acc)
            {
                var actype = (from nm in clientinf
                                  select nm).ElementAt(5);
                actype = acc;
                clientinf[5] = actype;
                Console.WriteLine("\nSuccessfully updated.\n");
            }
        }
        class ChequingAcc
        {
            public double balcheq = 800;
            private int reward = 0;
            public void depositcheq(double amt)
            {
                balcheq += amt;
                Console.WriteLine("$" + amt + " deposited succesfully. \nNew balance= $" + balcheq);
            }
            public void withdrawcheq( double amt)
            {
                balcheq -= amt;
                Console.WriteLine("$" + amt + " withdrawn succesfully. \nNew balance= $" + balcheq);
            }
            public void rewardpts()
            {
                if (balcheq >= 2000 && balcheq<2500)
                {
                    reward += 10;
                }
                else if(balcheq>=2500)
                {
                    reward += 5;
                }
                Console.WriteLine("You have " + reward + " points in this account.");
            }
            public void closed(int isclosed)
            {
                if (isclosed == 1)
                {
                    Console.WriteLine("This account has been closed.");
                }
            }
        }
        class BasicAcc
        {
            public double balbasic = 500;
            private int reward = 0;
            public void depositbasic(double amt)
            {
                balbasic += amt;
                Console.WriteLine("$" + amt + " deposited succesfully. \nNew balance= $" + balbasic);
            }
            public void withdrawbasic(double amt)
            {
                balbasic -= amt;
                Console.WriteLine("$" + amt + " withdrawn succesfully. \nNew balance= $" + balbasic);
            }
            public void rewardpts()
            {
                if (balbasic >= 2000 && balbasic < 2500)
                {
                    reward += 10;
                }
                else if (balbasic >= 2500)
                {
                    reward += 5;
                }
                Console.WriteLine("You have " + reward + " points in this account.");
            }
            public void closed(int isclosed)
            {
                if (isclosed == 0)
                {
                    Console.WriteLine("This account has been closed.");
                }
            }
        }
        class PreferredPkg
        {
            public double balpref = 600;
            private int reward = 0;
            public void depositpref(double amt)
            {
                balpref += amt;
                Console.WriteLine("$" + amt + " deposited succesfully. \nNew balance= $" + balpref);
            }
            public void withdrawpref(double amt)
            {
                balpref -= amt;
                Console.WriteLine("$" + amt + " withdrawn succesfully. \nNew balance= $" + balpref);
            }
            public void rewardpts()
            {
                if (balpref >= 2000 && balpref < 2500)
                {
                    reward += 10;
                }
                else if (balpref >= 2500)
                {
                    reward += 5;
                }
                Console.WriteLine("You have " + reward + " points in this account.");
            }
            public void closed(int isclosed)
            {
                if (isclosed == 0)
                {
                    Console.WriteLine("This account has been closed.");
                }
            }
        }
        class UltPkg
        {
            public double balult = 700;
            private int reward = 0;
            public void depositult(double amt)
            {
                balult += amt;
                Console.WriteLine("$" + amt + " deposited succesfully. \nNew balance= $" + balult);
            }
            public void withdrawult(double amt)
            {
                balult -= amt;
                Console.WriteLine("$" + amt + " withdrawn succesfully. \nNew balance= $" + balult);
            }
            public void rewardpts()
            {
                if (balult >= 2000 && balult < 2500)
                {
                    reward += 10;
                }
                else if (balult >= 2500)
                {
                    reward += 5;
                }
                Console.WriteLine("You have " + reward + " points in this account.");
            }
            public void closed(int isclosed)
            {
                if (isclosed == 0)
                {
                    Console.WriteLine("This account has been closed.");
                }
            }
        }
        static void Main(string[] args)
        {
            ClientAcc client = new ClientAcc();
            ChequingAcc cheque = new ChequingAcc();
            BasicAcc basic = new BasicAcc();
            PreferredPkg pref = new PreferredPkg();
            UltPkg ult = new UltPkg();
            int ch1 = 0, ch2 = 0, ch3=0, ch4=0;
            double amount = 0;
            int isclosed = 0;
            String pinenter;
            Console.WriteLine("\n\t Welcome to RBC\n");
            do
            {
                Console.WriteLine("\nPlease enter your PIN to access the account.(Current PIN is "+ client.clientinf[1] + ")");
                pinenter = Console.ReadLine();
                if (pinenter == client.clientinf[1])
                    //MAIN MENU
                {
                   
                    Console.WriteLine("Welcome " + client.clientinf[0]);
                    menu:
                    Console.WriteLine("\tMAIN MENU \n1.Account Balance \n2.Deposit \n3.Withdraw \n4.Reward Points balance \n5.Edit profile " +
                        "\n6.Close Account \n7.Exit \n Please enter a choice: ");
                    
                    do
                    {
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        switch (ch1)
                        {
                            //ACCOUNT BALANCE
                            case 1:
                                Console.Clear();
                                Console.WriteLine("\n\t ACCOUNT BALANCE\n1.Basic account \n2.Preferred Package \n3.Ultimate Package \n4.Chequing Account\n5. Back to main menu\n Enter your choice: ");
                                do
                                {
                                    ch2 = Convert.ToInt32(Console.ReadLine());
                                    switch (ch2)
                                    {
                                        case 1:
                                            Console.WriteLine("Your basic account has a balance of $"+ basic.balbasic);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 2:
                                            Console.WriteLine("Your preferred package account has a balance of $" + pref.balpref);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 3:
                                            Console.WriteLine("Your ultimate package account has a balance of $" + ult.balult);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 4:
                                            Console.WriteLine("Your chequing account has a balance of $" + cheque.balcheq);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 5:
                                            Console.Clear();
                                            goto menu;
                                        default:
                                            Console.WriteLine("Invalid Choice. Enter again");
                                            break;
                                    }
                                } while (ch2 > 0 && ch2 < 6);
                                break;

                            //DEPOSIT
                            case 2:
                                Console.Clear();
                                Console.WriteLine("\n\tDEPOSIT AMOUNT");
                                Console.WriteLine("\n1.Basic account \n2.Preferred Package \n3.Ultimate Package \n4.Chequing Account\n5. Back to main menu\n Enter your choice: ");
                                do {
                                    ch3 = Convert.ToInt32(Console.ReadLine());
                                    switch (ch3)
                                    {
                                        case 1:
                                            Console.WriteLine("Enter the amount to deposit");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            basic.depositbasic(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 2:
                                            Console.WriteLine("Enter the amount to deposit");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            pref.depositpref(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 3:
                                            Console.WriteLine("Enter the amount to deposit");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            ult.depositult(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 4:
                                            Console.WriteLine("Enter the amount to deposit");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            cheque.depositcheq(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 5:
                                            Console.Clear();
                                            goto menu;
                                        default:
                                            Console.WriteLine("Invalid choice. Enter again.");
                                            break;
                                    }
                                } while (ch3 > 0 && ch3 < 6);
                                break;

                            //WITHDRAWL
                            case 3:
                                Console.Clear();
                                Console.WriteLine("\n\tWITHDRAW AMOUNT");
                                Console.WriteLine("\n1.Basic account \n2.Preferred Package \n3.Ultimate Package \n4.Chequing Account\n5. Back to main menu\n Enter your choice: ");
                                do
                                {
                                    ch3 = Convert.ToInt32(Console.ReadLine());
                                    switch (ch3)
                                    {
                                        case 1:
                                            Console.WriteLine("Enter the amount to withdraw");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            basic.withdrawbasic(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 2:
                                            Console.WriteLine("Enter the amount to withdraw");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            pref.withdrawpref(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 3:
                                            Console.WriteLine("Enter the amount to withdraw");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            ult.withdrawult(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 4:
                                            Console.WriteLine("Enter the amount to withdraw");
                                            amount = Convert.ToDouble(Console.ReadLine());
                                            cheque.withdrawcheq(amount);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 5:
                                            Console.Clear();
                                            goto menu;
                                        default:
                                            Console.WriteLine("Invalid choice. Enter again.");
                                            break;
                                    }
                                } while (ch3 > 0 && ch3 < 6);
                                break;

                            //REWARD POINTS
                            case 4:
                                Console.Clear();
                                Console.WriteLine("\n\t REWARD POINTS");
                                Console.WriteLine("\n1.Basic account \n2.Preferred Package \n3.Ultimate Package \n4.Chequing Account\n5. Back to main menu\n Enter your choice: ");
                                do
                                {
                                    ch4 = Convert.ToInt32(Console.ReadLine());
                                    switch (ch4)
                                    {
                                        case 1:
                                            basic.rewardpts();
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 2:
                                            pref.rewardpts();
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 3:
                                            ult.rewardpts();
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 4:
                                            cheque.rewardpts();
                                            Console.WriteLine("\nEnter an option: ");
                                            break;
                                        case 5:
                                            Console.Clear();
                                            goto menu;
                                        default:
                                            Console.WriteLine("Invalid choice. Enter again.");
                                            break;
                                    }
                                } while (ch4 > 0 && ch4 < 6);
                                break;

                            //EDIT PROFILE
                            case 5:
                                Console.Clear();
                                Console.WriteLine("\n\t EDIT PROFILE");
                                Console.WriteLine("\n1.View profile \n2.Edit name \n3.Edit pin \n4.Edit address \n5.Edit phone\n6.Edit email \n7.Edit account type \n8.Back to main menu \nEnter your choice");
                                do{
                                    ch3 = Convert.ToInt32(Console.ReadLine());
                                    switch (ch3)
                                    {
                                        case 1:
                                            client.info();
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 2:
                                            Console.WriteLine("\nEnter your name ");
                                            string name = Console.ReadLine();
                                            client.editname(name);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 3:
                                            Console.WriteLine("\nEnter new pin ");
                                            string pin = Console.ReadLine();
                                            client.editpin(pin);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 4:
                                            Console.WriteLine("\nEnter your address ");
                                            string addr = Console.ReadLine();
                                            client.editaddr(addr);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 5:
                                            Console.WriteLine("\nEnter your phone number ");
                                            string ph = Console.ReadLine();
                                            client.editph(ph);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 6:
                                            Console.WriteLine("\nEnter your email ");
                                            string mail = Console.ReadLine();
                                            client.editmail(mail);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 7:
                                            Console.WriteLine("\nEnter your account type ");
                                            string ac = Console.ReadLine();
                                            client.editType(ac);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 8:
                                            Console.Clear();
                                            goto menu;

                                        default:
                                            Console.WriteLine("Invalid choice. Enter again.");
                                            break;

                                    }
                                }while (ch3 > 0 && ch3 < 9) ;
                                break;

                            //CLOSE ACCOUNT
                            case 6:
                                Console.Clear();
                                Console.WriteLine("\n\tCLOSE ACCOUNT \nSelect an account to close\n");
                                Console.WriteLine("\n1.Basic account \n2.Preferred Package \n3.Ultimate Package \n4.Chequing Account\n5. Back to main menu\n Enter your choice: ");
                                do
                                {
                                    ch3 = Convert.ToInt32(Console.ReadLine());
                                    switch (ch3)
                                    {
                                        case 1: 
                                            isclosed = 1;
                                            basic.closed(isclosed);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 2:
                                            isclosed = 1;
                                            pref.closed(isclosed);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 3:
                                            isclosed = 1;
                                            ult.closed(isclosed);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 4:
                                            isclosed = 1;
                                            cheque.closed(isclosed);
                                            Console.WriteLine("\nEnter an option: ");
                                            break;

                                        case 5:
                                            Console.Clear();
                                            goto menu;

                                        default:
                                            Console.WriteLine("Invalid choice. Enter again.");
                                            break;
                                    }
                                } while (ch3 > 0 && ch3 < 6);
                                break;

                            //EXIT PROGRAM
                            case 7:
                                System.Environment.Exit(1);
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Enter again.");
                                break;
                        }
                    } while (ch1 > 0 && ch1<8);
                }
                else
                {
                    Console.WriteLine("Wrong PIN entered. Try again.");
                }
            } while (pinenter != client.clientinf[1]);
        }
    }
}