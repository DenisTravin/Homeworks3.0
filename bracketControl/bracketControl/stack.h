#pragma once

struct StackElement;

struct Stack;

Stack* makeStack();//making stack

void stackPush(Stack *stack, int number);//push into stack

void stackPop(Stack *stack);//pop from stack

void stackDelete(Stack *stack);//delete all stack

int stackHead(Stack *stack);//return stack head value

bool stackEmpty(Stack *stack);//check is stack empty?