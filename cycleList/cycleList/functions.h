#pragma once

struct ListElement;

struct ListHead;

int seacrhLastWarrior(ListHead* list, int num, int mum);//seacrhing last warrior

ListHead* makeListHead(int num);//making list

ListElement* addElement(ListElement** source, ListElement* next, int number);//add list element

void printList(ListHead *list, int num);//output list

void delElement(ListElement *element);//delete element