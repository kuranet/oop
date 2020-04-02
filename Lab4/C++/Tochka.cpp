#pragma once
#include <string>

using namespace std;
class Tochka
{
public: double x;
		double y;
		Tochka(double s, double e)
		{
			x = s;
			y = e;
		}
		Tochka()
		{
			x = 0; y = 0;
		}
		Tochka(Tochka &obj)
		{
			x = obj.x; y = obj.y;
		}

		Tochka operator +(Tochka obj2)
		{
			Tochka result;
			result.x = x + obj2.x;
			result.y = y + obj2.y;
			return result;
		}
		Tochka operator -(Tochka obj2)
		{
			Tochka result;
			result.x = x - obj2.x;
			result.y = y - obj2.y;
			return result;
		}
};

