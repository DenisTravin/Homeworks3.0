#include <iostream>
#include <string>
#include "list.h"

using namespace std;
                           // 0  1  2  3
const int states[3][4] = {  { 1, 1, 2, 0 },  // /
							{ 0, 2, 3, 3 },  // *
							{ 0, 0, 2, 2 }}; // any

const bool isOutput[3][4] = { { false, false, true, true },
							  { false, true, true, true },
							  { false, false, true, true }};

//return table index for each symbol
int giveIndex(char symbol)
{
	switch (symbol)
	{
		case '/':
			return 0;
		case '*':
			return 1;
		default:
			return 2;
	}
}

//check is it comment or not
bool isComment(ListHead *list, int state, int symbol)
{
	if (symbol == '*' && state == 1)
	{
		addNewElement(list, '/');
	}
	return isOutput[giveIndex(symbol)][state];
}

//changing state
int changeState(int state, char symbol)
{
	return states[giveIndex(symbol)][state];
}

void main()
{
	FILE* file = fopen("in.txt", "r");
	if (file == nullptr)
	{
		printf("file not found\n");
		scanf("%*s");
		return;
	}
	ListHead *list = makeListHead();
	int state = 0;
	while (!feof(file))
	{
		char symbol = '\0';
		fscanf(file, "%c", &symbol);
		if (isComment(list, state, symbol))
		{
			addNewElement(list, symbol);
		}
		else
		{
			printList(list);
			removeListElements(list);
		}
		state = changeState(state, symbol);
	}
	removeAllList(list);
	scanf("%*s");
}