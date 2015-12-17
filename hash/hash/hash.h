#pragma once

using namespace std;

struct HashTable;

struct HashElement
{
	string name;
	int number;
};

HashTable *createTable();

int hashFunction(string &name);

void addTableElement(HashTable *table, string &word);

void printTable(HashTable *table);

void deleteHashTable(HashTable *table);

