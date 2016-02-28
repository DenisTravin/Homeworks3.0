#include <iostream>
#include "functions.h"

using namespace std;

struct ListElement
{
	int number;
	ListElement *next;
};

struct ListHead
{
	ListElement *head;
};

int seacrhLastWarrior(ListHead* list, int num, int mum)
{
	ListElement* temp = list->head;
	while (num > 1)
	{
		//printList(list, n - 1); //if you want to check program work - uncomment
		for (int i = 0; i < mum - 1; i++)
		{
			temp = temp->next;
		}
		if (list->head == temp->next)
		{
			list->head = temp->next->next;
		}
		delElement(temp);
		num--;
	}
	int result = temp->number;
	delete temp;
	delete list;
	return result;
}

ListHead* makeListHead(int num)
{
	ListHead* list = new ListHead;
	ListElement *newElement = new ListElement;
	list->head = newElement;
	newElement->next = nullptr;
	newElement->number = 0;
	ListElement *temp = newElement;
	for (int i = 1; i < num; i++)
	{
		temp = addElement(&temp, nullptr, i);
	}
	temp->next = list->head;
	temp = list->head;
	temp->number = num;
	return list;
}

ListElement* addElement(ListElement** source, ListElement* next,  int number)
{
	ListElement *newElement = new ListElement;
	(*source)->next = newElement;
	(*source) = newElement;
	newElement->number = number;
	newElement->next = next;
	return newElement;
}

void printList(ListHead *list, int num)//print out all list
{
	if (list->head == nullptr)
	{
		cout << "List is empty!" << endl;
		return;
	}
	ListElement *temp = list->head->next;
	for (int i = 0; i < num; i++)
	{
		cout << temp->number << " ";
		temp = temp->next;
	}
	cout << temp->number << " " << endl;
}

void delElement(ListElement *element)
{
	ListHead keapNextElement;
	keapNextElement.head = element->next->next;
	delete element->next;
	element->next = keapNextElement.head;
}