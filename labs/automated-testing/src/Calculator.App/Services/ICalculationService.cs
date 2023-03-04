using System;

namespace Calculator.App.Services;

    public interface ICalculatorService
    {
        int Operate(int left, int right);
    }