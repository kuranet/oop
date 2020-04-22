#include <iostream>
//#include "Tochka.cpp"
#include "Line.h"
#include "Section.h"
using namespace std;

int main()
{
	Section var0(0,0, 2,5);
	Line var1(6,0,6,3);
	Line var2(1,1,4,10);

	var0.Increase2();

	var0.EndCoord();

	cout << "Lengths: " << endl;
	cout << var0.Length << endl;
	cout << var1.Length << endl;
	cout << var2.Length << endl;
	system("pause");

}
