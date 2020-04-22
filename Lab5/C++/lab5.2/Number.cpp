#include "Number.h"

Number::Number() : Str() { };
Number::Number(string s) { str = s; LenCount(s); };

void Number::LenCount(string s) 
{
	int tempLen = 0;
	error = false;
	for (int i = 0; i < s.length(); i++) 
	{		
		if (isdigit(s[i])) {
			tempLen++;
		}
		else error = true;
	}
	len = tempLen;
}
void Number::Processing()
{
	for (int i = 0; i < str.length(); i++) {
		if (isdigit(str[i])) 
		{			
			str.insert(i, 1, str[i]);
			i++;
		}
	}
	LenCount(str);
}