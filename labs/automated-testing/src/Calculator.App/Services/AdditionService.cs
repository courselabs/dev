using System;

namespace Calculator.App.Services;

    public class AdditionService : ICalculatorService
    {
        public int Operate(int left, int right)
        {
            return left + right;
        }
    }