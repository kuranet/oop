#pragma once
class Tochka
{
public: double x;
		double y;

		Tochka(double s, double e);
		Tochka();
		Tochka(Tochka &obj);

		Tochka operator +(Tochka obj2);
		Tochka operator -(Tochka obj2);
		Tochka operator *(double num);
};

