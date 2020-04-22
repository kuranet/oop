#pragma once
#include "Line.h"
class Section :
	public Line
{
public: Section();
		Section(Tochka s, Tochka e);
		Section Increase2();
		Tochka StartCoord();
		Tochka EndCoord();
};
