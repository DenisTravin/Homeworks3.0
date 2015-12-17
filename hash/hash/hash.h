#pragma once

using namespace std;

struct Table;

struct HashElement
{
	string name;
	int number;
};

Table *createTable();
int hashFunction(string &name);
void addTableElement(Table *table, string &word);
void printTable(Table *table);
void deleteHashTable(Table *table);
