#include <iostream>
#include "functions.h"

using namespace std;

struct ListElement
{
	int value;
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

void addNewElement(ListHead *list, int elementNum)
{
	ListElement *newElement = new ListElement;
	bool sortFlag = false;
	if (list->head == nullptr)
	{
		list->head = newElement;
		newElement->next = nullptr;
	}
	else
	{
		ListElement *tmp = list->head;
		if (tmp->value >= elementNum)
		{
			newElement->next = list->head;
			list->head = newElement;
			newElement->value = elementNum;
			return;
		}
		while (tmp->next != nullptr)
		{
			if (tmp->next->value >= elementNum)
			{
				newElement->next = tmp->next;
				tmp->next = newElement;
				sortFlag = true;
				break;
			}
			tmp = tmp->next;
		}
		if (!sortFlag)
		{
			tmp->next = newElement;
			newElement->next = nullptr;
		}
	}
	newElement->value = elementNum;
}

void printList(ListHead *list)
{
	if (list->head == nullptr)
	{
		cout << "List is empty!" << endl;
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

void delNextElement(ListElement *element)
{
	ListElement* keepNextElement = element->next->next;
	delete element->next;
	element->next = keepNextElement;
}

void delElementByNumber(ListHead *list, int elementNum)
{
	while (list->head != nullptr && list->head->value == elementNum)
	{
		ListElement* keepNextElelement = list->head->next;
		delete list->head;
		list->head = keepNextElelement;
	}
	if (list->head == nullptr)
	{
		return;
	}
	ListElement *tmp = list->head;
	while (tmp != nullptr && tmp->next != nullptr)
	{
		if (tmp->next->value == elementNum)
		{
			delNextElement(tmp);
		}
		tmp = tmp->next;
	}
}

void removeAllList(ListHead *list)
{
	if (list->head == nullptr)
	{
		delete list;
		return;
	}
	ListElement *tmp = list->head;
	ListElement *nextTmp = tmp->next;
	while (tmp->next != nullptr)
	{
		nextTmp = tmp->next;
		delete tmp;
		tmp = nextTmp;
	}
	delete tmp;
	delete list;
}