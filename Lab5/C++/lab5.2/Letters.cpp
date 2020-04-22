#include "Letters.h"

Letters::Letters() : Str() { };
Letters::Letters(string s) { str = s; LenCount(s); };

void Letters::LenCount(string s)
{
	int tempLen = 0;
	error = false;
	for (int i = 0; i < s.length(); i++)
	{
		if (isalpha(s[i])) {
			tempLen++;
		}
		else error = true;
	}
	len = tempLen;
}
void Letters::Processing()
{
	reverse(str.begin(), str.end());
}