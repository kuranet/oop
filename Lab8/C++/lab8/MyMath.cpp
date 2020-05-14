#include "MyMath.h"
double MyMath::DoOperation(double value1, double value2, double(MyMath::* operation)(double value1, double value2))
{
	if (operation == nullptr)
		throw new std::exception("Operation must not be null");
	return (this->*operation)(value1, value2);
}
double MyMath::Add(double value1, double value2)
{
	return value1 + value2;
}
double MyMath::Subtract(double value1, double value2)
{
	return value1 - value2;
}
double MyMath::Multiply(double value1, double value2)
{
	return value1 * value2;
}
double MyMath::Divide(double value1, double value2)
{
	if (value2 == 0)
		throw new std::exception("Value2 must not be 0");
	return value1 / value2;
}