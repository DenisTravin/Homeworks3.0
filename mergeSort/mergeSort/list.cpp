#include <iostream>
#include <fstream>
#include "list.h"

using namespace std;

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

void addElement(ListHead* list, string name, string number)
{
	ListElement* newElement = new ListElement;
	newElement->human.name = name;
	newElement->human.number = number;
	newElement->next = list->head;
	list->head = newElement;
}
void splitList(ListElement *source, ListElement **front, ListElement **back)//split the list to two list's
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