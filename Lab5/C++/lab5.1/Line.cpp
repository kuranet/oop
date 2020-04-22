#include "Line.h"

Line::Line() {
	x1 = 0;  y1 = 0;
	x2 = 0; y2 = 0;
	GetLength();
}

Line::Line(double a, double b, double c, double d)
{
	x1 = a;
	x2 = c;
	y1 = b;
	y2 = d; 
	Length = GetLength();
};
double Line::GetLength()
{
	double len = sqrt(pow((x1-x2), 2) + pow((y1 - y2), 2));
	return len;
}