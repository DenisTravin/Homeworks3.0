#pragma once

struct ListElement;

struct ListHead;

// make list head
ListHead* makeListHead();

// add new element in list
void addNewElement(ListHead *list, char symbol);

// print out all list
void printList(ListHead *list);

// remove list elements
void removeListElements(ListHead* list);

// delete all list
void removeAllList(ListHead *element);