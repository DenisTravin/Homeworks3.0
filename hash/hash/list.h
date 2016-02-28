#pragma once

#include "hash.h"

struct ListElement;

struct ListHead;

// create new list
ListHead* createList();

// add element to list
void addElement(HashElement* newElement, ListHead *list);

// output all list
void printAllList(ListHead *list);

// delele all list
void deleteAllList(ListHead *list);