using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using po_lab1;

namespace po_lab1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Form1 form = new Form1();
            

            Application.Run(form);
        }
    }

    public class NumberConverter
    {
        public static string ConvertNumber(string number, int fromBase, int toBase)
        {
            string[] parts = number.Split('.');
            string integerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "0";

            int decimalIntegerPart = ConvertToDecimal(integerPart, fromBase);
            double decimalFractionalPart = ConvertFractionToDecimal(fractionalPart, fromBase);

            double decimalNumber = decimalIntegerPart + decimalFractionalPart;

            string result = ConvertFromDecimal(decimalNumber, toBase);
            return result;
        }

        private static int ConvertToDecimal(string number, int fromBase)
        {
            int decimalNumber = 0;
            int power = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = GetDigitValue(number[i]);
                decimalNumber += digit * (int)Math.Pow(fromBase, power);
                power++;
            }

            return decimalNumber;
        }

        private static int GetDigitValue(char digit)
        {
            if (char.IsDigit(digit))
            {
                return int.Parse(digit.ToString());
            }
            else
            {
                return digit switch
                {
                    'A' => 10,
                    'B' => 11,
                    'C' => 12,
                    'D' => 13,
                    'E' => 14,
                    'F' => 15,
                    _ => 0,
                };
            }
        }

        private static double ConvertFractionToDecimal(string fraction, int fromBase)
        {
            double decimalFraction = 0.0;

            for (int i = 0; i < fraction.Length; i++)
            {
                int digit = GetDigitValue(fraction[i]);
                decimalFraction += digit / Math.Pow(fromBase, i + 1);
            }

            return decimalFraction;
        }

        private static string ConvertFromDecimal(double decimalNumber, int toBase)
        {
            string result = "";
            int integerPart = (int)decimalNumber;
            double fractionalPart = decimalNumber - integerPart;

            while (integerPart > 0)
            {
                int remainder = integerPart % toBase;
                result = GetCharValue(remainder) + result;
                integerPart /= toBase;
            }

            if (fractionalPart > 0)
            {
                result += ".";
                for (int i = 0; i < 5; i++) // Display up to 5 decimal places
                {
                    fractionalPart *= toBase;
                    int wholePart = (int)fractionalPart;
                    result += GetCharValue(wholePart);
                    fractionalPart -= wholePart;
                }
            }

            return result;
        }

        private static char GetCharValue(int value)
        {
            return value switch
            {
                >= 0 and <= 9 => (char)(value + '0'),
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };
        }
    }
}


