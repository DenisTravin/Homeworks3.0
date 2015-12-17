#include <iostream>
#include <string>
#include "list.h"
#include "hash.h"

using namespace std;

int const arraySize = 100;

struct HashTable
{
	ListHead *array[arraySize];
};

HashTable *createTable()
{
	HashTable *table = new HashTable;
	for (int i = 0; i < arraySize; ++i)
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
	return (hash % arraySize + arraySize) % arraySize;
}

void addTableElement(HashTable *hashTable, string &word)
{
	ListHead *list = hashTable->array[hashFunction(word)];
	HashElement newElement;
	newElement.name = word;
	newElement.number = 1;
	addElement(newElement, list);
}

void printTable(HashTable *hashTable)
{
	for (int i = 0; i < arraySize; ++i)
	{
		printAllList(hashTable->array[i]);
	}
}

void deleteHashTable(HashTable *hashTable)
{
	for (int i = 0; i < arraySize; ++i)
	{
		deleteAllList(hashTable->array[i]);
	}
	delete hashTable;
}