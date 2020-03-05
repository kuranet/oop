#pragma once
#include <vector>
#include "Stroka.h"

class Text
{
	vector<Stroka> text;

public:
	void AddString(Stroka str)
	{
		text.push_back(str);
	}
	void RemoveString(int index)
	{
		text.erase(text.begin() + index - 1);
	}
	void Erase()
	{
		vector<Stroka> new_text;
		text = new_text;
	}
	double SymFindStr(char n)
	{
		int count = 0;
		int len = 0;
		double freq = 0;
		for (int i = 0; i < text.size(); i++)
		{
			count += text[i].SymFind(n, len);
		}
		freq = (double)count / len;
		return freq;
	}
	void FindSame() {
		bool issame = true;
		for (int i = 0; i < text.size() - 1; i++)
		{
			for (int j = i + 1; j < text.size(); j++)
			{
				issame = text[i].IsSame(text[i], text[j]);
				if (issame)
				{
					RemoveString(i + 1);
					i--;
					RemoveString(j);
					j -= 2;
				}
			}
		}
	}
	void Replace(int index, Stroka str)
	{
		text[index - 1] = str;
	}
};