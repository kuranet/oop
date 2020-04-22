#pragma once
#include "Line.h"

class Section :
	public Line
{
public: Section();
		Section(double a, double b, double c, double d);
		void Increase2();
		void StartCoord();
		void EndCoord();
};
