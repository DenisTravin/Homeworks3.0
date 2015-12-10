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
	return;
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

void delElement(ListElement *element)
{
	ListHead keapNextElement;
	keapNextElement.head = element->next->next;
	delete element->next;
	element->next = keapNextElement.head;
}

void delElementByNumber(ListHead *list, int elementNum)
{
	ListHead keapNextElement;
	while (list->head != nullptr && list->head->value == elementNum)
	{
		keapNextElement.head = list->head->next;
		delete list->head;
		list->head = keapNextElement.head;
	}
	if (list->head == nullptr)
	{
		return;
	}
	ListElement *tmp = list->head;
	while (tmp->next != nullptr)
	{
		if (tmp->next->value == elementNum)
		{
			delElement(tmp);
		}
		tmp = tmp->next;
	}
	return;
}

void removeAllList(ListHead *list)
{
	if (list->head == nullptr)
	{
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
	return;
}