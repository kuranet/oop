#include"time.h"
#include <iostream>
#include<string>
#include"MathExpression.h"

using namespace std;
void ExampleFunction();

int main()
{
	const int Length = 50;
	MathExpression* expression[Length];
	double* result = new double[Length];
	string* logList = new string[Length];

	srand(time(NULL));
	for (int i = 0; i < Length; i++)
	{
		expression[i] = new MathExpression(rand() % 10 - 5, rand() % 10 - 5, rand() % 10 + 15, rand() % 10 - 5);	
	}

	for (int i = 0; i < Length; i++)
	{
		try
		{
			result[i] = expression[i]->GetRes();
			logList[i] = "Success";
		}
		catch (invalid_argument& ex)
		{
			logList[i] = ex.what();
		}
	}

	for (int i = 0; i < Length; i++)
		cout << logList[i] << endl;

	ExampleFunction();
	
}
void ExampleFunction() {
	double res;
	string* loglist = new string[3];

	//Root Expression must be >= 0
	try
	{
		MathExpression exp(1, 2, 22, -30);
		res = exp.GetRes();
	}
	catch (invalid_argument ex)
	{
		loglist[0] = ex.what();
	}
	//Division by 0 by parameter b
	try
	{
		MathExpression exp(1, 0, 3, 4);
		res = exp.GetRes();
	}
	catch (invalid_argument ex)
	{
		loglist[1] = ex.what();
	}
	//Denominator is 0
	try
	{
		MathExpression exp(-6, 1, 0, 12);
		res = exp.GetRes();
	}
	catch (invalid_argument ex)
	{
		loglist[2] = ex.what();
	}
	cout << "\nExamples of exceptions: \n";
	for (int i = 0; i < 3; i++) {
		cout << i + 1 << "   " << loglist[i] << endl;
	}
}

