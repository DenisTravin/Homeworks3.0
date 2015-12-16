#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int p = 31;//hash const

long long powNum(int number, int pow)
{
	long long result = 1;
	for (int i = 0; i < pow; i++)
	{
		result *= (long long)number;
	}
	return result;
}

long long hashFunc(string source, int first, int last)
{
	long long result = 0;
	for (int i = first; i < last; i++)
	{
		result += (long long)(source[i] - 'a' + 1) * powNum(p, last - i - 1);
	}
	return result;
}

int funcRabinCarp(string text, string sub)
{
	int res = 0;
	int subLen = sub.length();
	long long hsub = hashFunc(sub, 0, subLen);
	long long hs = hashFunc(text, 0, subLen);
	for (int i = 1; i <= (int)text.length() - subLen + 1; i++)
	{
		if (hsub == hs)
		{
			bool checkEq = true;
			for (int j = 0; j < subLen; j++)
			{
				if (sub[j] != text[i + j - 1])
				{
					checkEq = false;
					break;
				}
			}
			if (checkEq)
			{
				return i;
			}
		}
		hs = (hs - (text[i - 1] - 'a' + 1) * powNum(p, subLen - 1)) * p + (text[i - 1 + subLen] - 'a' + 1);
	}
	return 0;
}

void main()
{
	string sub;
	string text;
	ifstream file("in.txt", ios::in);
	if (!file.is_open())
	{
		cout << "file not found" << endl;
		scanf("%*s");
		return;
	}
	while (!file.eof())
	{
		file >> text;
	}
	cout << "Text: " << text << endl;
	file.close();
	cout << "Input sub: ";
	cin >> sub;
	int result = funcRabinCarp(text, sub);
	if (funcRabinCarp(text, sub) == 0)
	{
		printf("Sub don't found");
	}
	else
	{
		printf("Sub found in %i position", result);
	}
	scanf("%*s");
}