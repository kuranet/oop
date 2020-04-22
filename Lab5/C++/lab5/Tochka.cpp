#include "Tochka.h"
using namespace std;

Tochka::Tochka(double s, double e)
{
	x = s;
	y = e;
}
Tochka::Tochka()
{
	x = 0; y = 0;
}

Tochka::Tochka(Tochka &obj)
{
	x = obj.x; y = obj.y;
}

Tochka Tochka:: operator +(Tochka obj2)
{
	Tochka result;
	result.x = x + obj2.x;
	result.y = y + obj2.y;
	return result;
}
Tochka Tochka:: operator -(Tochka obj2)
{
	Tochka result;
	result.x = x - obj2.x;
	result.y = y - obj2.y;
	return result;
}

Tochka Tochka:: operator *(double num)
{
	Tochka result;
	result.x = x * num;
	result.y = y * num;
	return result;

}


