﻿namespace S2_Ex1;

public class FullTimeEmployee : Employee
{
    public double MonthlySalary;

    public FullTimeEmployee(string name, double monthlySalary) : base(name)
    {
        MonthlySalary = monthlySalary;
    }

    public override double GetMonthlySalary()
    {
        return MonthlySalary;
    }
}