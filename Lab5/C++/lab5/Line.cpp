#include "Line.h"

Line::Line() {
	start = Tochka(); 
	end = Tochka();
}

Line::Line(Tochka s, Tochka e)
{
	start = s;
	end = e;
	Length = GetLength();
}
double Line:: GetLength()
{
	double len = sqrt(pow((start.x - end.x), 2) + pow((start.y - end.y), 2));
	return len;
}