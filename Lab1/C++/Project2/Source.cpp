#include <iostream>

using namespace std;

void Increment(int& n);
bool Compare();

int main()
{
	int n;
	n = 5;
	Increment(n);
	cout << "new n = " << n << endl;
	bool k = Compare();
	cout << k << endl;
	system("pause");
	return 0;
}

void Increment(int& n)
{
	cout << "n = ";
	cin >> n;
	int mask = 1;
	if (n == 0) { n = -1; }
	else {
		while (n & mask)
		{
			n &= ~mask;
			mask = mask << 1;
		}
		n |= mask;
	}
}

bool Compare()
{
	int n, m;
	cout << "n = "; cin >> n;
	cout << "m = "; cin >> m;
	bool output = false;
	char res = '=';
	if (!(n >> 31) && !(m >> 31))
	{
		int i = sizeof(n) * 8 - 1;
		while (i + 1)
		{
			int z = 1 << i;
			res = res == '=' ? (
				(n & z ^ m & z) ? ((n & z) ? '>' : '<') : '='
				) : res;
			i--;
		}
	}
	else if ((n >> 31) && (m >> 31))
	{
		int i = sizeof(n) * 8 - 1;
		while (i + 1)
		{
			int z = 1 << i;
			res = res == '=' ? (
				(~n & z ^ ~m & z) ? ((~n & z) ? '<' : '>') : '='
				) : res;
			i--;
		}
	}
	else if (!(n >> 31) && (m >> 31)) res = '>'; else res = '<';
	cout << n << res << m << endl;
	output = (res == '<') ? (true) : (false);
	return output;
}

	

