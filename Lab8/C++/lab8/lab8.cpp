// lab8.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include"IntArray.h"
#include"MyMath.h"

using namespace std;
void Display(string message);

int main()
{
	IntArray arr(4, 4);
	arr.OverRangeHandler(Display);
	arr.GetSum();

	MyMath mathOperations = MyMath();

	double(MyMath:: * operation)(double value1, double value2) = &MyMath::Add;
	double res [4];
	res[0] = mathOperations.DoOperation(3, 4, operation);
	operation = &MyMath::Subtract;
	res[1] = mathOperations.DoOperation(7, 3, operation);
	operation = &MyMath::Multiply;
	res[2] = mathOperations.DoOperation(3, 2, operation);
	operation = &MyMath::Divide;
	res[3] = mathOperations.DoOperation(11, 2, operation);
}
void Display(string message)
{
	std::cout << message;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
