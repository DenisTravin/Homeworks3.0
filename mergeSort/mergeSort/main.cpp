#include <iostream>
#include <fstream>
#include <string>
#include <algorithm>
#include "list.h"

using namespace std;

int numOfElem = 0;

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
			ListElement* source = returnListHead(list);
			mergeSort(&source, userChoise);
			changeListHead(list, source);
			printList(list, numOfElem);
			break;
		}
		case 3:
		{
			ListElement* source = returnListHead(list);
			mergeSort(&source, userChoise);
			changeListHead(list, source);
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
	removeAllList(list);
}