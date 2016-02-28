#include <iostream>
#include "binaryNumbers.h"

using namespace std;

void main()
{
	int n = 0;
	int m = 0;
	setlocale(LC_ALL, "Russian");
	printf("Введите n: ");
	scanf("%i", &n);
	printf("\nВведите m: ");
	scanf("%i", &m);
	printf("\nВ двоичной системе счисления: ");
	printf("\nn = ");
	BinNumber* nBin = makeBinNumber(n);
	printBinNum(nBin);
	printf("\nm = ");
	BinNumber* mBin = makeBinNumber(m);
	printBinNum(mBin);
	BinNumber* sumBin = makeBinSum(nBin, mBin);
	printf("\nn + m = ");
	printBinNum(sumBin);
	int sum = makeDecNumber(sumBin);
	printf("\nВ десятичной системе счисления: n + m = %i", sum);
	deleteBinNumber(nBin);
	deleteBinNumber(mBin);
	deleteBinNumber(sumBin);
	scanf("%*s");
}
/*
Test 1:
intput: n = 5, m = 5;
output: n = 101, m = 101, n + m = 1010;
n + m = 10
*/