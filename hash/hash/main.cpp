#include <iostream>
#include <string>
#include <fstream>
#include "list.h"
#include "hash.h"

using namespace std;

void main()
{
	HashTable *hashTable = createTable();
	ifstream file("text.txt", ios::in);
	if (!file.is_open())
	{
		cout << "File does not found" << endl;
	}
	else
	{
		while (!file.eof())
		{
			string newWord;
			file >> newWord;
			addTableElement(hashTable, newWord);
		}
		printTable(hashTable);
	}
	file.close();
	deleteHashTable(hashTable);
	scanf("%*s");
}