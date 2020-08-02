using System;

namespace GannSquareOfNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given calculation is based on: http://pivottrading.50webs.com/pivot/pivot/gann.html");
            double dbLastTradedPrice;
            Console.WriteLine("Please Enter Last Traded Price:");
            if (double.TryParse(Console.ReadLine(), out dbLastTradedPrice))
            {
                CalculateGannSquareOfNine(dbLastTradedPrice);
            }
            else
            {
                Console.WriteLine("Invalid input; please try again!");
            }
            
            Console.ReadKey();
        }
        static void CalculateGannSquareOfNine(double ltp)
        {
            // calculations
            double root = Math.Sqrt(ltp);
            double b2 = Math.Floor(root) - 1;
            double s0 = Math.Pow(b2, 2); // center
            double s1 = Math.Pow(b2 + 1 * 0.125, 2); // rotate 45 degrees
            double s2 = Math.Pow(b2 + 2 * 0.125, 2); // "
            double s3 = Math.Pow(b2 + 3 * 0.125, 2); // "
            double s4 = Math.Pow(b2 + 4 * 0.125, 2); // "
            double s5 = Math.Pow(b2 + 5 * 0.125, 2); // "
            double s6 = Math.Pow(b2 + 6 * 0.125, 2); // "
            double s7 = Math.Pow(b2 + 7 * 0.125, 2); // "
            double s8 = Math.Pow(b2 + 8 * 0.125, 2); // " - first level
            double s9 = Math.Pow(b2 + 9 * 0.125, 2); // "
            double s10 = Math.Pow(b2 + 10 * 0.125, 2); // "
            double s11 = Math.Pow(b2 + 11 * 0.125, 2); // "
            double s12 = Math.Pow(b2 + 12 * 0.125, 2); // "
            double s13 = Math.Pow(b2 + 13 * 0.125, 2); // "
            double s14 = Math.Pow(b2 + 14 * 0.125, 2); // "
            double s15 = Math.Pow(b2 + 15 * 0.125, 2); // "
            double s16 = Math.Pow(b2 + 16 * 0.125, 2); // " - second level
            double s17 = Math.Pow(b2 + 17 * 0.125, 2); // "
            double s18 = Math.Pow(b2 + 18 * 0.125, 2); // "
            double s19 = Math.Pow(b2 + 19 * 0.125, 2); // "
            double s20 = Math.Pow(b2 + 20 * 0.125, 2); // "
            double s21 = Math.Pow(b2 + 21 * 0.125, 2); // "
            double s22 = Math.Pow(b2 + 22 * 0.125, 2); // "
            double s23 = Math.Pow(b2 + 23 * 0.125, 2); // "
            double s24 = Math.Pow(b2 + 24 * 0.125, 2); // " - third level
            //double s25 = Math.Pow(b2 + 25 * 0.125, 2); // "
            //double s26 = Math.Pow(b2 + 26 * 0.125, 2); // "
            //double s27 = Math.Pow(b2 + 27 * 0.125, 2); // "
            //double s28 = Math.Pow(b2 + 28 * 0.125, 2); // "
            //double s29 = Math.Pow(b2 + 29 * 0.125, 2); // "
            //double s30 = Math.Pow(b2 + 30 * 0.125, 2); // "
            //double s31 = Math.Pow(b2 + 31 * 0.125, 2); // "
            //double s32 = Math.Pow(b2 + 32 * 0.125, 2); // " - fourth level
            //double s33 = Math.Pow(b2 + 33 * 0.125, 2); // "
            //double s34 = Math.Pow(b2 + 34 * 0.125, 2); // "
            //double s35 = Math.Pow(b2 + 35 * 0.125, 2); // "
            //double s36 = Math.Pow(b2 + 36 * 0.125, 2); // "
            //double s37 = Math.Pow(b2 + 37 * 0.125, 2); // "
            //double s38 = Math.Pow(b2 + 38 * 0.125, 2); // "
            //double s39 = Math.Pow(b2 + 39 * 0.125, 2); // "
            //double s40 = Math.Pow(b2 + 40 * 0.125, 2); // " - fifth level
            Console.WriteLine("Gann Square of 9 ");
            var t = new TablePrinter("Col1", "Col2", "Col3", "Col4", "Col5", "Col6", "Col7");
            t.AddRow(s18, String.Empty, String.Empty, s19, String.Empty, String.Empty, s20); //Row1
            t.AddRow(String.Empty, s10, String.Empty, s11, String.Empty, s12, String.Empty);//Row2
            t.AddRow(String.Empty, String.Empty, s2, s3, s4, String.Empty, String.Empty);//Row3
            t.AddRow(s17, s9, s1, s0, s5, s13, s21);//Row4
            t.AddRow(String.Empty, String.Empty, s8, s7, s6, String.Empty, String.Empty);//Row5
            t.AddRow(String.Empty, s16, String.Empty, s15, String.Empty, s14, String.Empty);//Row6
            t.AddRow(s24, String.Empty, String.Empty, s23, String.Empty, String.Empty, s22); //Row7
            t.Print();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Last Traded Price: " + ltp);
            Console.WriteLine();

            double[] dbSupportResistanceZones = { s18, s19, s20, s10, s11, s12, s2, s3, s4, s17, s9, s1, s0, s5, s13, s21, s8, s7, s6, s16, s15, s14, s24, s23, s22, ltp };
            Array.Sort(dbSupportResistanceZones);
            
            int index = Array.IndexOf(dbSupportResistanceZones, ltp);

            var resistances = new TablePrinter("Resistance 1", "Resistance 2", "Resistance 3", "Resistance 4", "Resistance 5", "Resistance 6");
            resistances.AddRow(dbSupportResistanceZones[index+1], dbSupportResistanceZones[index + 2], dbSupportResistanceZones[index + 3], dbSupportResistanceZones[index + 4], dbSupportResistanceZones[index + 5], dbSupportResistanceZones[index + 6]);
            resistances.Print();
            Console.WriteLine();
            Console.WriteLine();

            var support = new TablePrinter("Support 1", "Support 2", "Support 3", "Support 4", "Support 5", "Support 6");
            support.AddRow(dbSupportResistanceZones[index - 1], dbSupportResistanceZones[index - 2], dbSupportResistanceZones[index - 3], dbSupportResistanceZones[index - 4], dbSupportResistanceZones[index - 5], dbSupportResistanceZones[index - 6]);
            support.Print();
        }

        static void CalculateGannSquareOfNineOther(double ltp)
        {
            double square_root = Math.Round(Math.Sqrt(ltp));
            double one_num_below = square_root - 1;
            double two_num_below = square_root - 2;
            double one_num_above = square_root + 1;
            double two_num_above = square_root + 2;
            double center_value = two_num_below * two_num_below;
            double value_one = two_num_below + 0.125;
            double value_one_fin = Math.Round(value_one * value_one, 2);
            double value_two = value_one + 0.125;
            double value_two_fin = Math.Round(value_two * value_two, 2);
            double value_three = value_two + 0.125;
            double value_three_fin = Math.Round(value_three * value_three, 2);
            double value_four = value_three + 0.125;
            double value_four_fin = Math.Round(value_four * value_four, 2);
            double value_five = value_four + 0.125;
            double value_five_fin = Math.Round(value_five * value_five, 2);
            double value_six = value_five + 0.125;
            double value_six_fin = Math.Round(value_six * value_six, 2);
            double value_seven = value_six + 0.125;
            double value_seven_fin = Math.Round(value_seven * value_seven, 2);
            double value_eight = value_seven + 0.125;
            double value_eight_fin = Math.Round(value_eight * value_eight, 2);
            double value_nine = value_eight + 0.125;
            double value_nine_fin = Math.Round(value_nine * value_nine, 2);
            double value_ten = value_nine + 0.125;
            double value_ten_fin = Math.Round(value_ten * value_ten, 2);
            double value_eleven = value_ten + 0.125;
            double value_eleven_fin = Math.Round(value_eleven * value_eleven, 2);
            double value_twelve = value_eleven + 0.125;
            double value_twelve_fin = Math.Round(value_twelve * value_twelve, 2);
            double value_thirteen = value_twelve + 0.125;
            double value_thirteen_fin = Math.Round(value_thirteen * value_thirteen, 2);
            double value_fourteen = value_thirteen + 0.125;
            double value_fourteen_fin = Math.Round(value_fourteen * value_fourteen, 2);
            double value_fifteen = value_fourteen + 0.125;
            double value_fifteen_fin = Math.Round(value_fifteen * value_fifteen, 2);
            double value_sixteen = value_fifteen + 0.125;
            double value_sixteen_fin = Math.Round(value_sixteen * value_sixteen, 2);
            double value_seventeen = value_sixteen + 0.125;
            double value_seventeen_fin = Math.Round(value_seventeen * value_seventeen, 2);
            double value_eighteen = value_seventeen + 0.125;
            double value_eighteen_fin = Math.Round(value_eighteen * value_eighteen, 2);
            double value_nineteen = value_eighteen + 0.125;
            double value_nineteen_fin = Math.Round(value_nineteen * value_nineteen, 2);
            double value_twenty = value_nineteen + 0.125;
            double value_twenty_fin = Math.Round(value_twenty * value_twenty, 2);
            double value_twentyone = value_twenty + 0.125;
            double value_twentyone_fin = Math.Round(value_twentyone * value_twentyone, 2);
            double value_twentytwo = value_twentyone + 0.125;
            double value_twentytwo_fin = Math.Round(value_twentytwo * value_twentytwo, 2);
            double value_twentythree = value_twentytwo + 0.125;
            double value_twentythree_fin = Math.Round(value_twentythree * value_twentythree, 2);
            double value_twentyfour = value_twentythree + 0.125;
            double value_twentyfour_fin = Math.Round(value_twentyfour * value_twentyfour, 2);
            var t = new TablePrinter("Col1", "Col2", "Col3", "Col4", "Col5", "Col6", "Col7");
            t.AddRow(value_eighteen_fin, String.Empty, String.Empty, value_nineteen_fin, String.Empty, String.Empty, value_twenty_fin); //Row1
            t.AddRow(String.Empty, value_ten_fin, String.Empty, value_eleven_fin, String.Empty, value_twelve_fin, String.Empty);//Row2
            t.AddRow(String.Empty, String.Empty, value_two_fin, value_three_fin, value_four_fin, String.Empty, String.Empty);//Row3
            t.AddRow(value_seventeen_fin, value_nine_fin, value_one_fin, center_value, value_five_fin, value_thirteen_fin, value_twentyone_fin);//Row4
            t.AddRow(String.Empty, String.Empty, value_eight_fin, value_seven_fin, value_six_fin, String.Empty, String.Empty);//Row5
            t.AddRow(String.Empty, value_sixteen_fin, String.Empty, value_fifteen_fin, String.Empty, value_fourteen_fin, String.Empty);//Row6
            t.AddRow(value_twentyfour_fin, String.Empty, String.Empty, value_twentythree_fin, String.Empty, String.Empty, value_twentytwo_fin); //Row1
            t.Print();
        }
    }
}
