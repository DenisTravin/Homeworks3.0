#pragma once

struct StackElement;

struct Stack;
// making stack
Stack* makeStack();
// edit stach head value
void editStackHeadValue(Stack* stack, int number);
// push into stack
void stackPush(Stack *stack, int number);
// pop from stack
void stackPop(Stack *stack);
// delete all stack
void stackDelete(Stack *stack);
// return stack head value
int stackHead(Stack *stack);
// check is stack empty?
bool stackEmpty(Stack *stack);
// print and delete stack
void printAndDeleteStack(Stack* stack);