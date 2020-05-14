#include "IntArray.h"
#include <stdlib.h>
#include <time.h>
#include<exception>

using namespace std;

IntArray::IntArray(int n, int m)
{
	if (n <= 0 || m <= 0)
	  throw new std::exception("sdf");
	rows = n;
	columns = m;
	arr = new short*[n];
	for (int i = 0; i < n; i++) {
		arr[i] = new short[m];
	}
	srand(time(NULL));
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			arr[i][j] = (short)(rand() % 1000 + 2000);
		}
	}
}

double IntArray::GetSum()
{
	short sum = 0;
	int temp = arr[0][0];
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			sum += arr[i][j];
			if ((temp > 0 && arr[i][j] > 0 && sum < 0) || (temp < 0 && arr[i][j] < 0 && sum > 0))
			{
				operationHandler("OverRanged");
				break;
			}
			temp = arr[i][j];
		}
	}
	return sum;
}
void IntArray::OverRangeHandler(void(*operation)(std::string message))
{
	if (operation == nullptr)
		throw new std::exception("Operation must not be null");
	operationHandler = operation;
}