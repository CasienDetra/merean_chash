using System.Net.Security;

namespace Cashier;

class Program
{
    public static string[] Menu = new string[10]
    {
        "Capucino",
        "Iced Coffee",
        "Iced Latte",
        "Passion Cream",
        "Americano",
        "Matcha Latte",
        "Watermelon",
        "Lime Juice",
        "Lemonade",
        "Cupcake"
    };

    public static float[] Price = new float[10]
    {
        1.30f,
        1.50f,
        1.75f,
        1.90f,
        1.99f,
        1.99f,
        1.99f,
        1.99f,
        1.99f,
        1.99f,
    };

    public static float Tax_Rate = 0.3f;

    public static void Main(string[] args)
    {
        int[] qty = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int arrow = 0;

        // bill information
        float temp_total = 0;
        float total = 0;
        float discount = 0;
        string coupon_code = "";
        float tax = 0;
        while (1 != 0)
        {
            Console.Clear();
            PrintInstruction();
            PrintMenu(ref qty,ref arrow);

            temp_total = cal_temp_total(ref qty);
            tax = temp_total * Tax_Rate;
            total = temp_total + tax - discount;

            Console.WriteLine("Preview Your order:");

            Console.WriteLine("Your Order :" + temp_total.ToString("C2"));
            Console.WriteLine("Tax:"+tax.ToString("C2"));
            Console.WriteLine("Discount:"+discount.ToString("C2"));
            Console.WriteLine("Coupon:"+coupon_code);
            Console.WriteLine("Total"+ total.ToString("C2"));

            int option = UserInput();

            if (option == 1)
            {
               arrow = (arrow - 1 + Menu.Length) % Menu.Length;
            }
            else if (option == 2)
            {
                arrow = (arrow + 1 ) % Menu.Length;
            }
            else if (option == 3)
            {
                if (qty[arrow] > 0)
                {
                    qty[arrow]--;
                }
                else
                {
                    Console.WriteLine("The item is reaching 0");
                }
            }
            else if (option == 5)
            {
                Console.Clear();
                Console.WriteLine("Your order summary :");
                Console.WriteLine("");
            }
            else if (option == 4)
            {
                qty[arrow]++;
            }
            else if (option == 6)
            {
                Console.WriteLine("Please Enter Your Coupons Code:");
                string reedem_code = Console.ReadLine();

                float newdiscount = getdiscount(reedem_code , temp_total);

                if (newdiscount > 0)
                {
                    discount = newdiscount;
                    coupon_code = reedem_code;
                    Console.WriteLine("coupons Code Apply");

                }
                else
                {
                    Console.WriteLine("Invalid Coupons Code");
                }

            }
        }


    }
    public static void PrintBill()
    {

    }

    public static int UserInput()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow: return 1;
            case ConsoleKey.DownArrow: return 2;
            case ConsoleKey.LeftArrow: return 3;
            case ConsoleKey.RightArrow: return 4;
            case ConsoleKey.Enter: return 5;
            case ConsoleKey.C : return 6;
            case ConsoleKey.Q: return 7;
            default: return 0;
        }
    }

    public static float cal_temp_total(ref int[] qty)
    {
            float temp_total = 0;
            for (int i = 0; i < Price.Length; i++)
            {
                temp_total += Price[i] * qty[i];
            }

            return temp_total;
    }
    public static void PrintInstruction()
    {
        Console.WriteLine("+===================================================+\n|██████╗ ██╗███████╗███████╗                        |\n|██╔══██╗██║╚══███╔╝╚══███╔╝                        |\n|██████╔╝██║  ███╔╝   ███╔╝                         |\n|██╔══██╗██║ ███╔╝   ███╔╝                          |\n|██║  ██║██║███████╗███████╗                        |\n|╚═╝  ╚═╝╚═╝╚══════╝╚══════╝                        |\n| ██████╗ ██████╗ ███████╗███████╗███████╗██╗    ██╗|\n|██╔════╝██╔═══██╗██╔════╝██╔════╝██╔════╝██║    ██║|\n|██║     ██║   ██║█████╗  █████╗  █████╗  ██║ █╗ ██║|\n|██║     ██║   ██║██╔══╝  ██╔══╝  ██╔══╝  ██║███╗██║|\n|╚██████╗╚██████╔╝██║     ██║     ███████╗╚███╔███╔╝|\n| ╚═════╝ ╚═════╝ ╚═╝     ╚═╝     ╚══════╝ ╚══╝╚══╝ |\n+===================================================+");
        Console.WriteLine("Use arrow up/down to select item and left/right arrow to remove and add item");
    }

    public static void PrintMenu(ref int[] qty,ref int arrow)
    {
        Console.WriteLine("Item".PadRight(40)+"Price".PadRight(10)+"Quantity".PadRight(10));
        for (int i = 0; i < Menu.Length; i++)
        {
            if (i == arrow)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("->");
            }
            else
            {
                Console.Write("-");
            }
            Console.WriteLine(Menu[i].PadRight(40)+Price[i].ToString("C2").PadRight(10)+qty[i].ToString("C2").PadRight(10)+qty[i].ToString("C0"));
            Console.ResetColor();
        }
    }

    public static float getdiscount(string coupon_code, float temp_total)
    {
        if (coupon_code == "hello")
        {
            return temp_total;
        }
        return 0;
    }
}