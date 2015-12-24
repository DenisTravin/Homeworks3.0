#pragma once

struct HashTable;

struct HashElement;

HashTable *createTable();

// hash function
int hashFunction(const std::string &name);

// add element to table
void addTableElement(HashTable *table, const std::string &word);

// output all table
void printTable(HashTable *table);

// delete all table
void deleteHashTable(HashTable *table);

// return element word
std::string returnHashWord(HashElement* source);

// return element number's of word
int returnHashNumber(HashElement* source);

// +1 to element->number
void addNumberToWord(HashElement* source);


