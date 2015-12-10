#include <iostream>
#include "functions.h"

const int n = 10;
const int m = 3;

using namespace std;

void main()
{
	ListHead* list = makeListHead(n);
	cout << "The last number is: " << seacrhLastWarrior(list, n, m) << endl;
	scanf("%*s");
}
/*
Test 1:
Input: n = 10; m = 3;
Output: k = 4;
Test 2:
Input: n = 5; m = 4;
Output: k = 1;
*/