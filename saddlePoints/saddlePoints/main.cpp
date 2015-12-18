#include <iostream>
#include <fstream>
#include "matrix.h"

using namespace std;

int numOfSaddlePoints = 0;

void printMatrix(Matrix* matrix)//output matrix
{
	for (int i = 0; i < getHeightNumber(matrix); ++i)
	{
		for (int j = 0; j < getWidthNumber(matrix); ++j)
		{
			printf("%i ", getNumber(matrix, i, j));
		}
		printf("\n");
	}
}

bool isMaxInColumn(Matrix* matrix, int number, int columnNumber)//is max number in column
{
	for (int i = 0; i < getWidthNumber(matrix); i++)
	{
		if (number < getNumber(matrix, i, columnNumber))
		{
			return false;
		}
	}
	return true;
}

bool isMinInString(Matrix* matrix, int number, int stringNumber)//is min number in string
{
	for (int i = 0; i < getHeightNumber(matrix); i++)
	{
		if (number > getNumber(matrix, stringNumber, i))
		{
			return false;
		}
	}
	return true;
}

void searchSaddlePoints(Matrix* matrix)//searching saddle points
{
	for (int i = 0; i < getHeightNumber(matrix); i++)
	{
		for (int j = 0; j < getWidthNumber(matrix); j++)
		{
			if (isMinInString(matrix, getNumber(matrix, i, j), i))
			{
				if (isMaxInColumn(matrix, getNumber(matrix, i, j), j))
				{
					numOfSaddlePoints++;
					printf("%i saddle point is: %i ", numOfSaddlePoints, getNumber(matrix, i, j));
				}
			}
		}
	}
}

void main()
{
	const int matrixWidth = 5;
	const int matrixHeight = 4;
	Matrix* matrix = createMatrix(matrixWidth, matrixHeight);
	ifstream file("input.txt", ios::in);
	if (!file.is_open())
	{
		printf("File does not found\n");
		scanf("%*s");
		return;
	}
	while (!file.eof())
	{
		for (int i = 0; i < matrixHeight; ++i)
			for (int j = 0; j < matrixWidth; ++j)
			{
				int x = 0;
				file >> x;
				setNumber(matrix, i, j, x);
			}
	}
	printMatrix(matrix);
	searchSaddlePoints(matrix);
	printf("\nNum of saddle points is %i", numOfSaddlePoints);
	deleteMatrix(matrix);
	scanf("%*s");
}