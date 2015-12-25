#include <iostream>
#include <fstream>
#include "functions.h"

using namespace std;

void main()
{
	ifstream file("input.txt", ios::in);
	int line = 0;
	file >> line;
	int columns = 0;
	file >> columns;
	int **matrix = new int*[line];
	for (int i = 0; i < line; i++)
	{
		matrix[i] = new int[columns];
	}
	for (int i = 0; i < line; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			file >> matrix[i][j];
		}
	}
	file.close();

	out1Func(matrix, columns, line);
	out2Func(matrix, columns, line);
	out3Func(matrix, columns, line);

	for (int i = 0; i < line; i++)
	{
		delete[]matrix[i];
	}
	delete[]matrix;
}