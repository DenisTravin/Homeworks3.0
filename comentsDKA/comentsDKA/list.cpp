#include <iostream>
#include "list.h"

using namespace std;

struct ListElement
{
	char value;
	ListElement *next;
};

struct ListHead
{
	ListElement *head;
};

ListHead* makeListHead()
{
	ListHead* list = new ListHead;
	list->head = nullptr;
	return list;
}

void addNewElement(ListHead *list, char symbol)
{
	ListElement *newElement = new ListElement;
	newElement->value = symbol;
	newElement->next = nullptr;
	if (list->head == nullptr)
	{
		list->head = newElement;
	}
	else
	{
		ListElement* temp = list->head;
		while (temp->next != nullptr)
		{
			temp = temp->next;
		}
		temp->next = newElement;
	}
}

void printList(ListHead *list)
{
	if (list->head == nullptr)
	{
		return;
	}
	ListElement *temp = list->head;
	while (temp->next != nullptr)
	{
		cout << temp->value << " ";
		temp = temp->next;
	}
	cout << temp->value << " " << endl;
}

void removeListElements(ListHead* list)
{
	if (list->head != nullptr)
	{
		ListElement* temp = list->head;
		while (temp->next != nullptr)
		{
			ListElement* keepElementForDelete = temp->next;
			delete temp;
			temp = keepElementForDelete;
		}
		delete temp;
	}
	list->head = nullptr;
}

void removeAllList(ListHead *list)
{
	if (list->head != nullptr)
	{
		ListElement *temp = list->head;
		while (temp->next != nullptr)
		{
			ListElement* keepElementForDelete = temp->next;
			delete temp;
			temp = keepElementForDelete;
		}
		delete temp;
	}
	delete list;
}