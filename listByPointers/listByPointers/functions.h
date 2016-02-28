#pragma once

struct ListElement;

struct ListHead;
// make list head
ListHead* makeListHead();
// delete next element
void delNextElement(ListElement *element);
// add new element in list
void addNewElement(ListHead *list, int elementNum);
// print out all list
void printList(ListHead *list);
// delete elements from list with value = elementNum
void delElementByNumber(ListHead *list, int elementNum);
// delete all list
void removeAllList(ListHead *element);