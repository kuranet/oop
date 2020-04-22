#include "Section.h"

Section::Section() : Line() { };
Section::Section(Tochka s, Tochka e) : Line(s, e) { };

Section Section:: Increase2()
{
	Section res;
	res.start = res.start * 2;
	res.end = res.end * 2;
	return res;
}

Tochka Section::StartCoord() { return start; }
Tochka Section::EndCoord() { return end; }