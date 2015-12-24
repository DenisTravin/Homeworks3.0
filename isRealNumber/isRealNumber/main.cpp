#include <iostream>
#include <string>

using namespace std;

//check does char is digit
bool isDigit(char number)
{
	if (number >= '0' && number <= '9')
	{
		return true;
	}
	else
	{
		return false;
	}
}

//check does number is real
bool isNumberReal(const string &number)
{
	int state = 0;
	for (int i = 0; i < number.length(); i++)
	{
		switch (state)
		{
			case 0:
				if (isDigit(number[i]))
				{
					state = 1;
				}
				else
				{
					return false;
				}
				break;
			case 1:
				if (isDigit(number[i]))
				{
					state = 1;
				}
				else
				{
					if (number[i] == '.')
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
				if (isDigit(number[i]))
				{
					state = 3;
				}
				else
				{
					return false;
				}
				break;
			case 3:
				if (isDigit(number[i]))
				{
					state = 3;
				}
				else
				{
					if (number[i] == 'E')
					{
						state = 4;
					}
					else
					{
						return false;
					}
				}
				break;
			case 4:
				if (number[i] == '+' || number[i] == '-')
				{
					state = 5;
				}
				else
				{
					if (isDigit(number[i]))
					{
						state = 6;
					}
					else
					{
						return false;
					}
				}
				break;
			case 5:
				if (isDigit(number[i]))
				{
					state = 6;
				}
				else
				{
					return false;
				}
				break;
			case 6:
				if (isDigit(number[i]))
				{
					state = 6;
				}
				else
				{
					return false;
				}
		}
	}
	return (state == 6 || state == 3 || state == 1);
}

void main()
{
	string number = "1.2E4";
	if (isNumberReal(number))
	{
		cout << number << " is real" << endl;
	}
	else
	{
		cout << number << " isn't real" << endl;
	}
	scanf("%*s");
}

/*
Test 1: 
Input: 1.2E4";
Output: 1.2E4 is real

Test 2:
Input: 111.222E+3333
Output: 111.222E+3333 is real

Test 3:
Input: 1.2E+-1
Output: 1.2E+-1 isn't real

Test 4:
Input: 1.
Output: 1. isn't real
*/