#include <iostream>
#include <string>
#include "stack.h"

using namespace std;

bool bracketControl(int inputChar, Stack *stack)
{
	int outChar = 0;
	switch (inputChar)
	{
	case ')':
	{
		outChar = '(';
		break;
	}
	case ']':
	{
		outChar = '[';
		break;
	}
	case '}':
	{
		outChar = '{';
		break;
	}
	}
	if (stackEmpty(stack) || stackHead(stack) != outChar)
	{
		return false;
	}
	stackPop(stack);
	return true;
}

void main()
{
	string str = "[({()})]";
	Stack* stack = makeStack();
	bool isGood = true;
	for (int i = 0; i < str.size(); i++)
	{
		if (str[i] == '(' || str[i] == '{' || str[i] == '[')
		{
			stackPush(stack, str[i]);
			continue;
		}
		if (!(bracketControl(str[i], stack)))
		{
			isGood = false;
			break;
		}
	}
	if (!stackEmpty(stack))
	{
		isGood = false;
	}
	if (isGood)
	{
		printf("Balance is nice");
	}
	else
	{
		printf("Balance is bad");
	}
	stackDelete(stack);
	scanf("%*s");
}
/*
Test 1:
Input: [({)(})]
Output:Balance is bad
Test 2:
Input: [({()})]
Output:Balance is nice
Test 3:
Input: (
Output:Balance is bad
*/