#include <iostream>
#include <string>
#include "stack.h"

using namespace std;

void main()
{
	string str = "2 + 3 * 4";
	Stack* stack = makeStack();

	for (int i = 0; i < str.size(); i++)
	{
		if (str[i] == ' ')
		{
			continue;
		}
		if (str[i] <= '9' && str[i] >= '0')
		{
			printf("%c ", str[i]);
		}
		else
		{
			switch (str[i])
			{
				case '+':
				case '-':
					while (!stackEmpty(stack) && stackHead(stack) != '(')
					{
						printf("%c ", stackHead(stack));
						stackPop(stack);
					}
					stackPush(stack, str[i]);
					break;
				case '*':
				case '/':
					while (!stackEmpty(stack))
					{
						if (stackHead(stack) == '*' || stackHead(stack) == '/')
						{
							printf("%c ", stackHead(stack));
							stackPop(stack);
						}
						else
						{
							break;
						}
					}
					stackPush(stack, str[i]);
					break;
				case '(':
					stackPush(stack, '(');
					break;
				case ')':
					while (stackHead(stack) != '(')
					{
						if (stackEmpty(stack))
						{
							break;
						}
						printf("%c ", stackHead(stack));
						stackPop(stack);
					}
					stackPop(stack);
					break;
			}
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
Test 3:
Input: 2 * 3 + 4 
Output: 2 3 * 4 +
*/