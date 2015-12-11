#include <iostream>
#include <string>
#include "stack.h"

using namespace std;

void main()
{
	string str = "((5 - 4) + 1 ) / 2";
	Stack* stack = makeStack();

	for (int i = 0; i < str.size(); i++)
	{
		if (str[i] == ' ')
			continue;
		if (str[i] <= '9' && str[i] >= '0')
		{
			printf("%c ", str[i]);
		}
		if (str[i] == '+' || str[i] == '*' || str[i] == '-' || str[i] == '/' || str[i] == '(')
		{
			stackPush(stack, str[i]);
		}
		if (str[i] == ')')
		{
			while (stackHead(stack) != '(')
			{
				printf("%c ", stackHead(stack));
				stackPop(stack);
			}
			stackPop(stack);
		}

	}
	printAndDeleteStack(stack);
	scanf("%*s");
}
/*
Test 1:
Input: (1 + 1) * 2
Output: 1 1 + 2 *
Test 2:
Input: ((5 - 4) + 1 ) / 2
Output: 5 4 - 1 + 2 /
*/