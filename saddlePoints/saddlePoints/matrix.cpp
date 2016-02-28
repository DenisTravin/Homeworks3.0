#include <iostream>
#include "matrix.h"

using namespace std;

struct Matrix
{
	int ** array;
	int matrixWidth;
	int matrixHeight;
};

Matrix* createMatrix(int matrixWidth, int matrixHeight)
{
	Matrix *matrix = new Matrix;
	matrix->array = new int*[matrixWidth];
	for (int i = 0; i < matrixWidth; ++i)
	{
		matrix->array[i] = new int[matrixHeight];
	}
	for (int i = 0; i < matrixHeight; ++i)
	{
		for (int j = 0; j < matrixWidth; ++j)
		{
			matrix->array[i][j] = 0;
		}
	}
	matrix->matrixWidth = matrixWidth;
	matrix->matrixHeight = matrixHeight;
	return matrix;
}

void setNumber(Matrix* matrix, int stringNumber, int columnNumber, int number)
{
	matrix->array[stringNumber][columnNumber] = number;
}

int getNumber(Matrix* matrix, int stringNumber, int columnNumber)
{
	return matrix->array[stringNumber][columnNumber];
}

int getWidthNumber(Matrix* matrix)
{
	return matrix->matrixWidth;
}

int getHeightNumber(Matrix* matrix)
{
	return matrix->matrixHeight;
}

void deleteMatrix(Matrix* matrix)
{
	for (int i = 0; i < matrix->matrixWidth; i++)
	{
		delete (matrix->array[i]);
	}
	delete matrix->array;
	delete matrix;
}