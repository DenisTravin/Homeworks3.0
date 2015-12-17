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
	ListElement *secTemp = temp;
	while (temp != nullptr)
	{
		secTemp = temp->next;
		delete temp;
		temp = secTemp;
	}
	delete temp;
	delete secTemp;
	delete list;
}

bool existInList(HashElement &sample, ListHead *list)
{
	ListElement *temp = list->head;
	while (temp != nullptr)
	{
		if (temp->element.name == sample.name)
		{
			return true;
		}
		temp = temp->next;
	}
	return false;
}

void IncNumber(HashElement &sample, ListHead *list)
{
	ListElement *temp = list->head;
	while (temp != nullptr)
	{
		if (temp->element.name == sample.name)
		{
			temp->element.number++;
			return;
		}
		temp = temp->next;
	}
}

void insert(HashElement &newElement, ListHead *list)
{
	ListElement *temp = new ListElement;
	temp->next = nullptr;
	temp->element = newElement;

	if (list->head != nullptr)
	{
		if (existInList(newElement, list))
		{
			delete temp;
			IncNumber(newElement, list);
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
		std::cout << "Word: " << temp->element.name << " uses " << temp->element.number << " times";
		temp = temp->next;
		std::cout << std::endl;
	}
}