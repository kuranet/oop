#pragma once
//#include "Tochka.h"
#include<cmath>

using namespace std;

class Line
{
protected: double x1,
	x2,
	y1,
	y2;
		  
public: double Length;
		Line();
		Line(double a, double b, double c, double d);

protected: double GetLength();
};

