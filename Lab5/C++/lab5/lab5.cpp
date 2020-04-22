#include <iostream>
#include "Tochka.cpp"
#include "Line.h"
#include "Section.h"
using namespace std;

int main()
{
	Tochka start;
	Tochka end (2,5);
	Section var0 ( start, end);
	start = Tochka(6, 0);
	end = Tochka(6, 3);
	Line var1 (start, end);
	start = Tochka(1, 1);
	end = Tochka(4, 10);
	Line var2(start, end);

	var0 = var0.Increase2();

	cout << "X: " << var0.EndCoord.XCoord << " Y: " << var0.EndCoord.YCoord << endl;
	cout << "Lengths: " << endl;
	cout << var0.Length << endl;
	cout << var1.Length << endl;
	cout << var2.Length << endl;
	system("pause");
    
}
