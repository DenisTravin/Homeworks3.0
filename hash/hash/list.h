#pragma once

#include "hash.h"

struct ListElement;

struct ListHead;

ListHead* createList();//create new list

void insert(HashElement &newElement, ListHead *list);//add element to list

void printAllList(ListHead *list);//output all list

void deleteAllList(ListHead *list);//delele all list