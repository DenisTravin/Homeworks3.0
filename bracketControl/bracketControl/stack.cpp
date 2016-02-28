#include <iostream>
#include "stack.h"

using namespace std;

struct StackElement
{
	int value;
	StackElement *next;
};

struct Stack
{
	StackElement *head;
};

Stack* makeStack()
{
	Stack* stack = new Stack;
	stack->head = nullptr;
	return stack;
}

void stackPush(Stack *stack, int number)
{
	StackElement *newElement = new StackElement;
	newElement->value = number;
	newElement->next = stack->head;
	stack->head = newElement;
}

// int stackPop(Stack *stack) // if you need to have pop element - uncomment
void stackPop(Stack *stack)
{
	if (stack->head == nullptr)
	{
		// return - 1 // if you need to have pop element - uncomment
		return;
	}
	//int value = stack->head->value; // if you need to have pop element - uncomment
	StackElement *temp = stack->head->next;
	delete stack->head;
	stack->head = temp;
	// return value; // if you need to have pop element - uncomment
	return;
}

void stackDelete(Stack *stack)
{
	while (stack->head != nullptr)
	{
		StackElement *temp = stack->head;
		stack->head = stack->head->next;
		delete temp;
	}
	delete stack;
}

int stackHead(Stack *stack)
{
	return stack->head->value;
}

bool stackEmpty(Stack *stack)
{
	return stack->head == nullptr;
}