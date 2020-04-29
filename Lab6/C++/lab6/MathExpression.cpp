#include "MathExpression.h"
#include <iostream>
#include <Math.h>

using namespace std;

MathExpression::MathExpression(double a, double b, double c, double d) {
	this->a = a;
	this->b = b;
	this->c = c;
	this->d = d;
}
double MathExpression::GetRes() 
{
	double Sqrt = 24 + d - c;
	if (Sqrt < 0)
		throw  invalid_argument("Root Expression must be >= 0");

	if (b == 0)
		throw invalid_argument("Division by 0 by parameter b");
	
	double denomination = sqrt(Sqrt) + (a / b);
	if (denomination == 0)
		throw invalid_argument("Denominator is 0");

	double result = (1 + a - b / 2) / denomination;
	return result;
}