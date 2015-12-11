#include <iostream>
#include <fstream>
#include <string>
#include <algorithm>
#include "list.h"

using namespace std;

int numOfElem = 0;

int stringComp(string a, string b)//string compare
{
	int minSize = min(a.size(), b.size());
	for (int i = 0; i < minSize; i++)
	{
		if (a[i] != b[i])
			return (int)(b[i] - a[i]);
	}
}

ListElement* mergeFunc(ListElement *a, ListElement *b, int userChoise)//return smallest element of part of the list, reccursion with next element
{
	ListElement *result = nullptr;
	int cmpResult = 0;
	if (a == nullptr)
	{
		return(b);
	}
	else if (b == nullptr)
	{
		return(a);
	}
	if (userChoise == 2)
	{
		cmpResult = stringComp(a->human.name, b->human.name);
	}
	else
	{
		cmpResult = stringComp(a->human.number, b->human.number);
	}
	if (cmpResult >= 0)
	{
		result = a;
		result->next = mergeFunc(a->next, b, userChoise);
	}
	else
	{
		result = b;
		result->next = mergeFunc(a, b->next, userChoise);
	}
	return result;
}

void mergeSort(ListElement **headSource, int userChoise)//split the list and sort both parts
{
	ListElement *head = *headSource;
	ListElement *firstList;
	ListElement *secondList;
	if (head == nullptr || head->next == nullptr)
	{
		return;
	}
	splitList(head, &firstList, &secondList);
	mergeSort(&firstList, userChoise);
	mergeSort(&secondList, userChoise);
	*headSource = mergeFunc(firstList, secondList, userChoise);
}

void main()
{
	ListHead* list = makeList();
	int userChoise = -1;
	string findNum;
	bool havePerson = false;
	ifstream fin("out.txt");
	if (!fin.is_open())
		cout << "File can't be open" << endl;
	else
	{
		fin >> numOfElem;
		for (int i = 0; i <= numOfElem; i++)
		{
			string name;
			string number;
			fin >> name;
			fin >> number;
			addElement(list, name, number);
		}
	}
	fin.close();
	printList(list, numOfElem);
	while (userChoise != 0)
	{
		cout << "0 - close program" << endl << "1 - add new person" << endl << "2 - sort by name" << endl
			<< "3 - sort by numbers" << endl << "4 - save list and close program" << endl;
		cin >> userChoise;
		switch (userChoise)
		{
		case 1:
		{
			string name;
			string number;
			cout << "Input name:";
			cin >> name;
			cout << "Input phone number:";
			cin >> number;
			addElement(list, name, number);
			numOfElem++;
			printList(list, numOfElem);
			break;
		}
		case 2:
		{
			mergeSort(&list->head, userChoise);
			printList(list, numOfElem);
			break;
		}
		case 3:
		{
			mergeSort(&list->head, userChoise);
			printList(list, numOfElem);
			break;
		}
		case 4:
		{

			saveListIntoFile(list, numOfElem);
			userChoise = 0;
			break;
		}
		}
	}
}