#pragma once
#include<string>
class MyMath
{
public:
	double DoOperation(double value1, double value2, double (MyMath::* operation)(double value1, double value2));
	double Add(double value1, double value2);
	double Subtract(double value1, double value2);
	double Multiply(double value1, double value2);
	double Divide(double value1, double value2);
private:
	double(*operation)(double value1, double value2);
};


