#pragma once
#include<string>
class IntArray
{
public: IntArray(int n, int m);
		double GetSum();
		void OverRangeHandler(void(*operation)(std::string message));
private: double(*operation)(double value1, double value2);
		 void(*operationHandler)(std::string message);
		 short** arr;
		 int rows;
		 int columns;
};

