#pragma once
#include "Str.h"
class Letters :
	public Str
{
public: Letters();
		Letters(string s);
		void Processing();

private: void LenCount(string s);
};

