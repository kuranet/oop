#include<iostream>
#include "Text.h"
#include "Stroka.h"
using namespace std;

	int main()
	{
		Stroka str1, str2, str3, str4;
		Text text;
		str1.Str("adafaf");
		str2.Str("123123");
		str3.Str("!#!$$");
		str4.Str("asdasfdfwfwew123");
		text.AddString(str1);
		text.AddString(str2);
		text.AddString(str3);
		text.AddString(str4);
		text.AddString(str4);
		text.SymFindStr('1');
		text.RemoveString(1);
		text.Replace(3,str1);
		text.FindSame();
		text.Erase();
	}
