#include "Section.h"
#include <iostream>


Section::Section() : Line() { };
Section::Section(double a, double b, double c, double d) : Line(a, b, c, d) {};

void Section::Increase2()
{	
	x1 = x1 * 2;
	x2 = x2 * 2;
	y1 = y1 * 2;
	y2 = y2 * 2;
	Length = GetLength();
}

void Section::StartCoord() { cout << "X: " << x1 << " Y: " << y1 << endl; }
void Section::EndCoord() { cout << "X: " << x2 << " Y: " << y2 << endl; }