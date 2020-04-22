#pragma once
#include "Tochka.h"
#include<cmath>

class Line
{
protected: Tochka start;
		   Tochka end;
public: double Length;
		Line();
		Line(Tochka s, Tochka e);
private: double GetLength();
};

