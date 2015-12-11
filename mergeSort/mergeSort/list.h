#pragma once
#include <string> 

using namespace std;

struct Person
{
	string name;
	string number;
};

struct ListElement
{
	Person human;
	ListElement *next;
};

struct ListHead
{
	ListElement *head;
};

ListHead* makeList();

void addElement(ListHead* list, string name, string number);

void printList(ListHead *list, int num);

void splitList(ListElement *source, ListElement **front, ListElement **back);

int length(ListElement* head);

void saveListIntoFile(ListHead* list, int numOfElements);