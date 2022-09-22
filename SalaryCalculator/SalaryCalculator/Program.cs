using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta brutotasu:");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());

            if (brutoSalary <= 1200)
            {
                if (brutoSalary <= 500)
                {
                    SalaryIsLessThan500(brutoSalary);
                }
                else
                {
                    SalaryIsLessThan1200(brutoSalary);
                }
                
            }

            if (brutoSalary >= 1201 && brutoSalary <= 2099)
            {
                SalaryIsBetween1201and2099(brutoSalary);
            }

            if (brutoSalary >= 2100)
            {
                SalaryIsAbove2100(brutoSalary);
            }

        }

        public static void SalaryIsLessThan500(double brutoSalary)
        {
            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;
            double netIncome = brutoSalary - unemploymentTax - pensionFond;
            Console.WriteLine($"Sinu netotasu: {netIncome}");

        }

        public static void SalaryIsLessThan1200(double brutoSalary)
        {
            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;
            double incomeTax = (brutoSalary - 500 - pensionFond - unemploymentTax) * 0.2;
            double netIncome = brutoSalary - incomeTax - unemploymentTax - pensionFond;
            Console.WriteLine($"Sinu netotasu: {netIncome}");
        }

        public static void SalaryIsBetween1201and2099(double brutoSalary)
        {
            double coefficient = 0.55556;
            double deductibleIncome = brutoSalary - 1200;
            double monthlyMaxTaxSumMinusDeductibleIncome = coefficient * deductibleIncome;
            double incomeTaxFree = 500 - monthlyMaxTaxSumMinusDeductibleIncome;

            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;
            double incomeTax = (brutoSalary - pensionFond - unemploymentTax - incomeTaxFree) * 0.2;

            double netIncome = brutoSalary - incomeTax - unemploymentTax - pensionFond;
            Console.WriteLine($"Sinu netotasu: {netIncome}");

        }

        public static void SalaryIsAbove2100(double brutoSalary)
        {
            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;

            double incomeTax = 0.2 * (brutoSalary - pensionFond - unemploymentTax);
            double netIncome = brutoSalary - incomeTax - unemploymentTax - pensionFond;
            Console.WriteLine($"Sinu netotasu: {netIncome}");
        }

    }
}
