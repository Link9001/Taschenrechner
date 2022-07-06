using System;

namespace Taschenrechner
{
    public class CalculationExpression
    {
        public CalculationOperations? Operation { get; set; }

        private double? secondNumber;
        private double? firstNumber;

        public double FirstNumber => secondNumber ?? 0;

        public double SecondNumber => secondNumber ?? 0;

        public CalculationExpression(double firstNumber)
        {
            this.firstNumber = firstNumber;
        }

        public void SetNumber(double number)
        {
            if (Operation == null)
            {
                firstNumber = number;
            }
            else
            {
                secondNumber = number;
            }
        }

        public double Caluculate()
        {
            switch (Operation)
            {
                case CalculationOperations.Addition:
                    return FirstNumber + SecondNumber;
                case CalculationOperations.Substraktion:
                    return FirstNumber - SecondNumber;
                case CalculationOperations.Multiplication:
                    return FirstNumber * SecondNumber;
                case CalculationOperations.Division:
                    if (FirstNumber != 0 && SecondNumber != 0)
                    {
                        return FirstNumber / SecondNumber;
                    }

                    return double.NaN;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public enum CalculationOperations
        {
            Addition = 0,
            Substraktion = 1,
            Multiplication = 2,
            Division = 3,
        }

        public override string ToString()
        {
            return $"{FirstNumber} {Operation} {SecondNumber}";
        }
    }
}