#include <iostream>
#include <string>
#include "list.h"

struct ListElement
{
	ListElement *prev;
	HashElement element;
	ListElement *next;
};

struct ListHead
{
	ListElement *head;
	ListElement *tail;
};

ListHead* createList()
{
	ListHead *list = new ListHead;
	list->head = nullptr;
	list->tail = nullptr;
	return list;
}

void deleteAllList(ListHead *list)
{
	ListElement *temp = list->head;
	while (temp != nullptr && temp->next != nullptr)
	{
		temp = temp->next;
		delete temp->prev;
	}
	delete temp;
	delete list;
}

bool isELementInList(HashElement source, ListHead *list)
{
	ListElement *temp = list->head;
	while (temp != nullptr)
	{
		if (temp->element.name == source.name)
		{
			return true;
		}
		temp = temp->next;
	}
	return false;
}

void findWord(HashElement source, ListHead *list)
{
	ListElement *temp = list->head;
	while (temp != nullptr)
	{
		if (temp->element.name == source.name)
		{
			temp->element.number++;
			return;
		}
		temp = temp->next;
	}
}

void addElement(HashElement newElement, ListHead *list)
{
	ListElement *temp = new ListElement;
	temp->next = nullptr;
	temp->element = newElement;

	if (list->head != nullptr)
	{
		if (isELementInList(newElement, list))
		{
			delete temp;
			findWord(newElement, list);
			return;
		}
		temp->prev = list->tail;
		list->tail->next = temp;
		list->tail = temp;
	}
	else
	{
		temp->prev = nullptr;
		list->head = temp;
		list->tail = temp;
	}
}

void printAllList(ListHead *list)
{
	ListElement *temp = list->head;
	while (temp != nullptr)
	{
		cout << "Word: '" << temp->element.name << "' uses " << temp->element.number << " times" << endl;
		temp = temp->next;
	}
}