#include <iostream>
#include <string>

using namespace std;

enum class State
{
	start,
	firstDigit,
	point,
	secondDigit, 
	exp,
	plusOrMinus,
	lastDigit
};

//check does char is digit
bool isDigit(char number)
{
	return number >= '0' && number <= '9';
}

//check does number is real
bool isNumberReal(const string &number)
{
	State state = State::start;
	for (int i = 0; i < number.length(); i++)
	{
		switch (state)
		{
		case State::start:
				if (isDigit(number[i]))
				{
					state = State::firstDigit;
				}
				else
				{
					return false;
				}
				break;
			case State::firstDigit:
				if (isDigit(number[i]))
				{
					state = State::firstDigit;
				}
				else
				{
					if (number[i] == '.')
					{
						state = State::point;
					}
					else
					{
						if (number[i] == 'E')
						{
							state = State::exp;
						}
						else
						{
							return false;
						}
					}
				}
				break;
			case State::point:
				if (isDigit(number[i]))
				{
					state = State::secondDigit;
				}
				else
				{
					return false;
				}
				break;
			case State::secondDigit:
				if (isDigit(number[i]))
				{
					state = State::secondDigit;
				}
				else
				{
					if (number[i] == 'E')
					{
						state = State::exp;
					}
					else
					{
						return false;
					}
				}
				break;
			case State::exp:
				if (number[i] == '+' || number[i] == '-')
				{
					state = State::plusOrMinus;
				}
				else
				{
					if (isDigit(number[i]))
					{
						state = State::lastDigit;
					}
					else
					{
						return false;
					}
				}
				break;
			case State::plusOrMinus:
				if (isDigit(number[i]))
				{
					state = State::lastDigit;
				}
				else
				{
					return false;
				}
				break;
			case State::lastDigit:
				if (isDigit(number[i]))
				{
					state = State::lastDigit;
				}
				else
				{
					return false;
				}
		}
	}
	return (state == State::lastDigit || state == State::secondDigit || state == State::firstDigit);
}

void main()
{
	string number = "1.E4";
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