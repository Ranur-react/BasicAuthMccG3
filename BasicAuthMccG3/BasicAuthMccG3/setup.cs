using System;

namespace BasicAuthMccG3
{
    class setup
    {
        private static string[] listMenu = new string[7] { "Creat User  ", "Show User", "Search", "Edit User", "Delete User", "Login", "Exit" };
        public static Display print = new Display(60, "left", "space");
        static void Main(string[] args)
        {
            bool state = true;
            do
            {
                state = ShowMenu("BASIC USER AUTHENTICATION");
            } while (state);
        }

        private static bool ShowMenu(string title)
        {
            bool state = true;
            int index = 0;
            String decodeStringMenu = "";
            print.Header(title);
            print.Content($"  MENU: ");
            foreach (String i in listMenu)
            {
                index++;
                decodeStringMenu += $"  ({index}) {i}|";
                print.Content($" [{index}.] {i}");
            }
            print.Content($"|Pres Key  1 -{index} to select Menu | press Q for Exit Sessions");
            print.Box("");
            state = SelectMenu("Select Number Menu :");
            print.Footer("");
            return state;
        }

        /*
        ThreadStaticAttribute is funtions for select menu options its was show front of
        you can select with numbering format
         */
        public static bool SelectMenu(string v)
        {
            bool rentry = false;
            int limite = 0;
            String i = "";
            do
            {
                try
                {
                    Console.Write(v);
                    String options = Console.ReadLine();
                    if (options.ToLower() == "q")
                    {
                        print.Content("Process was stoped");
                        return false;
                    }
                    else
                    {
                        switch (Convert.ToInt32(options))
                        {
                            case 1:
                                i = listMenu[0];
                                limite = AskingLimitInput($"Entry {i} Range : ");
                                //new ProgramInput(0, limite);
                                new CreateUser(0,limite);
                                break;
                            case 2:
                                i = listMenu[1];
                                limite = AskingLimitInput($"Entry  {i} Range : ");
                                //new ProgramInput(1, limite);
                                break;
                            default:
                                return false;
                                break;
                        }
                    }
                    rentry = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\t\t ! ~Erros Messages " + e.Message);
                    rentry = true;
                }
            } while (rentry);
            return true;
        }
        private static int AskingLimitInput(String v)
        {
            bool rentry = false;
            int limit = 0;
            do
            {
                try
                {
                    Console.Write(v);
                    limit = Convert.ToInt32(Console.ReadLine());
                    if (limit < 1)
                    {
                        rentry = true;
                        Console.WriteLine($"\t\t ! range it's more then {limit} ");
                    }
                    else
                    {
                        rentry = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\t\t ! ~Erros Messages " + e.Message);
                    rentry = true;
                }
            } while (rentry);
            return limit;

        }
    }
}
