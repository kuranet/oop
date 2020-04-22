#pragma once
#include "Str.h"
class Number :
	public Str
{
public: Number();
		Number(string s);
		void Processing();

private: void LenCount(string s);
};

