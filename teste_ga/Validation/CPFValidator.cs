using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace teste_ga.Validation
{
    public static class CPFValidator
    {

        public static bool IsValid(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            var digits = Regex.Replace(cpf, @"\D", "");


            if (digits.Length != 11)
                return false;

            if (digits.Distinct().Count() == 1)
                return false;


            var firstNine = digits.Substring(0, 9);
            int firstCheck = CalculateCheckDigit(firstNine, new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 });


            var firstTen = firstNine + firstCheck.ToString();
            int secondCheck = CalculateCheckDigit(firstTen, new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 });


            return digits[9].ToString() == firstCheck.ToString() &&
                   digits[10].ToString() == secondCheck.ToString();
        }


        public static string Format(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return cpf;

            var digits = Regex.Replace(cpf, @"\D", "");
            if (digits.Length != 11) return cpf;

            return string.Format("{0}.{1}.{2}-{3}",
                digits.Substring(0, 3),
                digits.Substring(3, 3),
                digits.Substring(6, 3),
                digits.Substring(9, 2));
        }


        private static int CalculateCheckDigit(string numbers, int[] multiplicadores)
        {
            int sum = 0;
            for (int i = 0; i < multiplicadores.Length; i++)
            {
                int num = numbers[i] - '0';
                sum += num * multiplicadores[i];
            }

            int remainder = sum % 11;
            int digit = remainder < 2 ? 0 : 11 - remainder;
            return digit;
        }
    }
}
