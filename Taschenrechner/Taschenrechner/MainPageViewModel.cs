using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Taschenrechner
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] 
        private double result;

        private CalculationExpression expression;

        private string number = string.Empty;
        private readonly List<CalculationExpression> expressions = new List<CalculationExpression>();

        public CalculationExpression CurrentExpression
        {
            get => expressions.Last();
            set
            {
                if (SetProperty(ref expression, value))
                {
                    expressions.Add(value);
                    expression = value;
                }
            }
        }

        [ICommand]
        private void Add()
        {
            CurrentExpression.SetNumber(double.Parse(number));
            CurrentExpression.Operation = CalculationExpression.CalculationOperations.Addition;
            number = string.Empty;
        }

        [ICommand]
        private void Sub()
        {
            CurrentExpression.SetNumber(double.Parse(number));
            CurrentExpression.Operation = CalculationExpression.CalculationOperations.Substraktion;
            number = string.Empty;
        }

        [ICommand]
        private void Mult()
        {
            CurrentExpression.SetNumber(double.Parse(number));
            CurrentExpression.Operation = CalculationExpression.CalculationOperations.Multiplication;
            number = string.Empty;
        }

        [ICommand]
        private void Div()
        {
            CurrentExpression.SetNumber(double.Parse(number));
            CurrentExpression.Operation = CalculationExpression.CalculationOperations.Division;
            number = string.Empty;
        }
        [ICommand]
        private void Dot()
        {
            number += ".";
        }

        [ICommand]
        private void One()
        {
            number += "1";
        }
        [ICommand]
        private void Two()
        {
            number += "2";
        }
        [ICommand]
        private void Three()
        {
            number += "3";
        }
        [ICommand]
        private void Four()
        {
            number += "4";
        }
        [ICommand]
        private void Five()
        {
            number += "5";
        }
        [ICommand]
        private void Six()
        {
            number += "6";
        }
        [ICommand]
        private void Seven()
        {
            number += "7";
        }
        [ICommand]
        private void Eight()
        {
            number += "8";
        }
        [ICommand]
        private void Nine()
        {
            number += "9";
        }
        [ICommand]
        private void Zero()
        {
            number += "0";
        }

        [ICommand]
        private void Equal()
        {
            foreach (var calculationExpression in expressions)
            {
                result += calculationExpression.Caluculate();
            }
        }
    }
}
