#pragma once
#include <string>
using namespace std;
class Stroka
{
	string strochka;
public:

	void Str(string str)
	{
		strochka = str;
	}
	int Count()
	{
		return strochka.size();
	}
	int SymFind(char n, int& len)
	{
		int count = 0;
		len += Count();
		for (int i = 0; i < Count(); i++)
		{
			if (strochka[i] == n)
				count++;
		}
		return count;
	}
	bool IsSame(Stroka str1, Stroka str2) {

		bool issame = true;
		

		if (str1.strochka.length() == str2.strochka.length())
		{
			int i = 0;
			while (issame == true && i < str1.strochka.length())
			{
				if (str1.strochka[i] != str2.strochka[i])
					issame = false;
				i++;
			}
		}
		else issame = false;
		return issame;
	}
};