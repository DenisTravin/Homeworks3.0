#pragma once
#include <string> 

using namespace std;

struct Person;

struct ListElement;

struct ListHead;

ListHead* makeList();//make new list

void addElement(ListHead* list, string name, string number);//add element to list

void printList(ListHead *list, int num);//output all list

void splitList(ListElement *source, ListElement **front, ListElement **back);//split the list to two list's

int length(ListElement* head);//return lenght of list

void saveListIntoFile(ListHead* list, int numOfElements);//saving list into file

ListElement* mergeFunc(ListElement *a, ListElement *b, int userChoise);//return smallest element of part of the list, reccursion with next element

bool checkNull(ListElement* source);//check is source or source->next == nullptr

ListElement* returnListHead(ListHead* list);//return list head element