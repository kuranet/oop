#include "Str.h"

Str::Str() { str = ""; len = 0; error = true; }
Str::Str(string s) { str = s; LenCount(s); error = false; }

void Str::LenCount(string str) 
{
	len = str.length();
}
void Str::Processing(){}