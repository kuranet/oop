#pragma once
#include "Tochka.cpp"
#include <string>

using namespace std;

class Vidrizok
{
		Tochka start;
		Tochka end;
		public: 
			double Dlina;

			Vidrizok() { start = Tochka(); end = Tochka(); }
		Vidrizok(Tochka s, Tochka e)
		{
			start = s;
			end = e;
			Getdlina();
		}
		Vidrizok(double x1, double y1, double x2, double y2)
		{

			start = Tochka(x1, y1);
			end = Tochka(x2, y2);
			Getdlina();
		}
		Vidrizok(Vidrizok &obj) 
		{ 
			start = obj.start; 
			end = obj.end; 
		}
		Vidrizok(Tochka s, double x2, double y2)
		{
			start = s;
			end = Tochka(x2, y2);
			Getdlina();
		}
		Vidrizok(double x1, double y1, Tochka e)
		{
			start = Tochka(x1, y1);
			end = e;
			Getdlina();
		}
		Vidrizok operator +(Vidrizok obj2)
		{
			Vidrizok result;
			result.start = start + obj2.start;
			result.end = end + obj2.end;
			result.Getdlina();
			return result;
		}
		Vidrizok operator -(Vidrizok obj2)
		{
			Vidrizok result;
			result.start = start - obj2.start;
			result.end = end - obj2.end;
			result.Getdlina();
			return result;
		}
		void Sdvig(Vidrizok &obj, double x, double y)
		{
			Tochka temp (x, y);
			obj.start = obj.start + temp;
			obj.end = obj.end + temp;
			obj.Getdlina();
		}

		private: void Getdlina()
		{
			Dlina = sqrt(pow(start.x - end.x, 2) + pow(start.y - end.y, 2));
		}
		
};

