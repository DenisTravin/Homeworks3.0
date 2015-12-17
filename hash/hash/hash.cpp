#include <iostream>
#include <string>
#include "list.h"
#include "hash.h"

using namespace std;

int const amount = 100;

struct Table
{
	ListHead *array[amount];
};

Table *createTable()
{
	Table *table = new Table;
	for (int i = 0; i < amount; ++i)
	{
		table->array[i] = createList();
	}
	return table;
}

int hashFunction(string &name)
{
	int hash = 0;
	int multiplier = 1;
	for (int i = 0; i < name.length(); ++i)
	{
		hash += (int)name[i] * multiplier;
		multiplier *= 31;
	}
	return (hash % amount + amount) % amount;
}

void addTableElement(Table *table, string &word)
{
	ListHead *list = table->array[hashFunction(word)];
	HashElement newElement;
	newElement.name = word;
	newElement.number = 1;
	insert(newElement, list);
}

void printTable(Table *table)
{
	for (int i = 0; i < amount; ++i)
	{
		printAllList(table->array[i]);
	}
}

void deleteHashTable(Table *table)
{
	for (int i = 0; i < amount; ++i)
	{
		deleteAllList(table->array[i]);
	}
	delete table;
}