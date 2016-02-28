#include <iostream>
#include "binaryNumbers.h"

struct BinNumber
{
	int arrayBin[maxNum];
};

BinNumber* makeBinNumber(int number)
{
	BinNumber *binNumber = new BinNumber;
	for (int i = maxNum; i > 0; i--)
	{
		if ((1 << (i - 1)) & number)
		{
			binNumber->arrayBin[maxNum - i] = 1;
		}
		else
		{
			binNumber->arrayBin[maxNum - i] = 0;
		}
	}
	return binNumber;
}

void printBinNum(BinNumber* binNumber)
{
	for (int i = 0; i < maxNum; i++)
	{
		printf("%i", binNumber->arrayBin[i]);
	}
}

BinNumber* makeBinSum(BinNumber* firstBinNumber, BinNumber* secondBinNumber)
{
	BinNumber *binSum = new BinNumber;
	int additionData = 0;
	for (int i = maxNum - 1; i >= 0; i--)
	{
		int tempForSum = firstBinNumber->arrayBin[i] + secondBinNumber->arrayBin[i] + additionData;
		if (tempForSum < 2)
		{
			binSum->arrayBin[i] = tempForSum;
			additionData = 0;
		}
		else
		{
			binSum->arrayBin[i] = tempForSum - 2;
			additionData = 1;
		}
	}
	return binSum;
}

int makePow(int number, int pow)
{
	int result = 1;
	for (int i = 0; i < pow; i++)
	{
		result *= number;
	}
	return result;
}

int makeDecNumber(BinNumber* binNumber)
{
	int result = 0;
	for (int i = 0; i < maxNum; i++)
	{
		result += binNumber->arrayBin[i] * makePow(2, maxNum - i - 1);
	}
	return result;
}

void deleteBinNumber(BinNumber* binNumber)
{
	delete binNumber;
}