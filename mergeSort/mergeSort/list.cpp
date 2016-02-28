#include <iostream>
#include <fstream>
#include <string>
#include <algorithm>
#include "list.h"

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

// return lenght of list
int length(ListElement* head)
{
	int count = 0;
	ListElement* current = head;
	while (current != nullptr)
	{
		count++;
		current = current->next;
	}
	return count;
}

ListHead* makeList()
{
	ListHead* list = new ListHead;
	list->head = nullptr;
	return list;
}

void changeListHead(ListHead* list, ListElement* source)
{
	list->head = source;
}

void addElement(ListHead* list, const string &name, const string &number)
{
	ListElement* newElement = new ListElement;
	newElement->human.name = name;
	newElement->human.number = number;
	newElement->next = list->head;
	list->head = newElement;
}

// split the list to two list's
void splitList(ListElement *source, ListElement **front, ListElement **back)
{
	ListElement *current = source;
	int len = length(source);
	if (len < 2)
	{
		*front = current;
		*back = nullptr;
	}
	else
	{
		for (int i = 0; i < (len - 1) / 2; i++)
		{
			current = current->next;
		}
		*front = source;
		*back = current->next;
		current->next = nullptr;
	}
}

void printList(ListHead *list, int num)
{
	cout << "Your phonebook: " << endl;
	if (list->head == nullptr)
	{
		cout << "List is empty!" << endl;
		return;
	}
	cout << list->head->human.name << " " << list->head->human.number << endl;
	ListElement *temp = list->head->next;
	for (int i = 0; i < num - 1; i++)
	{
		cout << temp->human.name << " " << temp->human.number << endl;
		temp = temp->next;
	}
	cout << temp->human.name << " " << temp->human.number << endl;
}

void saveListIntoFile(ListHead* list, int numOfElements)
{
	ofstream fout;
	fout.open("out.txt");
	fout << numOfElements << endl;
	for (int i = 0; i <= numOfElements; i++)
	{
		fout << list->head->human.name << " " << list->head->human.number << endl;
		ListElement *temp = list->head->next;
		delete list->head;
		list->head = temp;
	}
	delete list;
	cout << "List was saved" << endl;
	fout.close();
}

// string compare
int stringComp(const string &a, const string &b)
{
	int minSize = min(a.size(), b.size());
	for (int i = 0; i < minSize; i++)
	{
		if (a[i] != b[i])
			return (int)(b[i] - a[i]);
	}
}

//return smallest element of part of the list, reccursion with next element
ListElement* mergeFunc(ListElement *a, ListElement *b, int userChoise)
{
	ListElement *result = nullptr;
	int cmpResult = 0;
	if (a == nullptr)
	{
		return b;
	}
	else if (b == nullptr)
	{
		return a;
	}
	if (userChoise == 2)
	{
		cmpResult = stringComp(a->human.name, b->human.name);
	}
	else
	{
		cmpResult = stringComp(a->human.number, b->human.number);
	}
	if (cmpResult >= 0)
	{
		result = a;
		result->next = mergeFunc(a->next, b, userChoise);
	}
	else
	{
		result = b;
		result->next = mergeFunc(a, b->next, userChoise);
	}
	return result;
}

//check is source or source->next == nullptr
bool checkNull(ListElement* source)
{
	return source == nullptr || source->next == nullptr;
}

ListElement* returnListHead(ListHead* list)
{
	return list->head;
}

void mergeSort(ListElement **headSource, int userChoise)
{
	ListElement *head = *headSource;
	ListElement *firstList = nullptr;
	ListElement *secondList = nullptr;
	if (checkNull(head))
	{
		return;
	}
	splitList(head, &firstList, &secondList);
	mergeSort(&firstList, userChoise);
	mergeSort(&secondList, userChoise);
	*headSource = mergeFunc(firstList, secondList, userChoise);
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