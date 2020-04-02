#include <iostream>
#include "Vidrizok.cpp"
#include "Tochka.cpp"
using namespace std;

int main()
{
	Tochka start1;
	Tochka end1 (3, 9);
	Tochka start2 (end1);
	Vidrizok W1 (start1, end1);
	Vidrizok W2 (start2, 8, 5);
	Vidrizok W3 (W2);
	W3.Sdvig(W3,3, 0);
	W3 = W1 + W2;
}
