#include <iostream>
#include <string>

using namespace std;

// check does char is letter
bool isLetter(char symbol)
{
	return symbol >= 'A' && symbol <= 'Z';
}

// check does char is digit
bool isDigit(char symbol)
{
	return symbol >= '0' && symbol <= '9';
}

// is char OK for first check
bool isFirstCheck(char symbol)
{
	return isDigit(symbol) || isLetter(symbol) || symbol == '.' || symbol == '_'
		|| symbol == '%' || symbol == '+' || symbol == '-';
}

// is symbol OK for second check
bool isSecondCheck(char symbol)
{
	return isDigit(symbol) || symbol == '-';
}

// check does string OK for our condition
bool isNiceString(const string &inputString)
{
	int state = 0;
	for (int i = 0; i < inputString.length(); i++)
	{
		switch (state)
		{
		case 0:
			if (isFirstCheck(inputString[i]))
			{
				state = 1;
			}
			else
			{
				return false;
			}
			break;
		case 1:
			if (isFirstCheck(inputString[i]))
			{
				state = 1;
			}
			else
			{
				if (inputString[i] == '@')
				{
					state = 2;
				}
				else
				{
					return false;
				}
			}
			break;
		case 2:
			if (isLetter(inputString[i]))
			{
				state = 4;
			}
			else
			{
				if (isSecondCheck(inputString[i]))
				{
					state = 3;
				}
				else
				{
					return false;
				}
			}
			break;
		case 3:
			if (inputString[i] == '.')
			{
				state = 2;
			}
			else
			{
				return false;
			}
			break;
		case 4:
			if (inputString[i] == '.')
			{
				state = 2;
			}
			else
			{
				return false;
			}
			break;
		}
	}
	return (state == 4);
}

void main()
{
	string number = "A9@F.9.-.F";
	if (isNiceString(number))
	{
		cout << number << " is nice" << endl;
	}
	else
	{
		cout << number << " is bad" << endl;
	}
	scanf("%*s");
}
