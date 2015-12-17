#pragma once

using namespace std;

struct HashTable;

struct HashElement;

HashTable *createTable();

int hashFunction(string name);//hash function

void addTableElement(HashTable *table, string word);//add element to table

void printTable(HashTable *table);//output all table

void deleteHashTable(HashTable *table);//delete all table

string returnHashWord(HashElement* source);//return element word

int returnHashNumber(HashElement* source);//return element number's of word

void addNumberToWord(HashElement* source);//+1 to element->number


