#pragma once
#ifndef TOCHKA_H  
#define TOCHKA_H 

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

#endif