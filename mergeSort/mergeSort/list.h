#pragma once

struct Person;

struct ListElement;

struct ListHead;

ListHead* makeList();

// change list head to source element
void changeListHead(ListHead* list, ListElement* source);

// add element to list
void addElement(ListHead* list, const std::string &name, const std::string &number);

// output all list
void printList(ListHead *list, int num);

//saving list into file
void saveListIntoFile(ListHead* list, int numOfElements);

//return list head element
ListElement* returnListHead(ListHead* list);

//split the list and sort both parts
void mergeSort(ListElement **headSource, int userChoise);

// remove all list
void removeAllList(ListHead *list);