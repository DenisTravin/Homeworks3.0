#pragma once

struct ListElement;

struct ListHead;

ListHead* makeListHead();//make list head

void delElement(ListElement *element);//delete element

void addNewElement(ListHead *list, int elementNum);//add new element in list

void printList(ListHead *list);//print out all list

void delElementByNumber(ListHead *list, int elementNum);//delete elements from list with value = elementNum

void removeAllList(ListHead *element);//delete all list