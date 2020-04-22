#pragma once
#ifndef STR_H  
#define STR_H 

#include <string>
using namespace std;

class Str
{
protected: string str;
		   int len;
		   bool error;

public: Str();
		Str(string s);
		virtual void Processing();

private: virtual void LenCount(string str);

};
#endif // STR_H