#include <iostream>
#include <string>
#include <fstream>
#include "list.h"
#include "hash.h"

void main()
{
	HashTable *table = createTable();
	ifstream file("text.txt", ios::in);
	if (!file.is_open())
	{
		cout << "File does not found" << endl;
		deleteHashTable(table);
	}
	else
	{
		while (!file.eof())
		{
			string newWord;
			file >> newWord;
			addTableElement(table, newWord);
		}
		printTable(table);
	}
	file.close();
	deleteHashTable(table);
	scanf("%*s");
}