#pragma once

struct StackElement;

struct Stack;

Stack* makeStack();
void printAndDeleteStack(Stack* stack);
void stackPush(Stack *stack, int number);
void stackPop(Stack *stack);
void stackDelete(Stack *stack);
int stackHead(Stack *stack);
bool stackEmpty(Stack *stack);