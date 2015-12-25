#include <iostream>
#include <fstream>
#include "functions.h"

using namespace std;

void out1Func(int* matrix[], int columns, int line)
{
	ofstream out1("out1.txt", ios::out);
	bool **boolMatrix = new bool*[line];

	for (int i = 0; i < line; i++)
	{
		boolMatrix[i] = new bool[columns];
		for (int j = 0; j < columns; j++)
		{
			boolMatrix[i][j] = false;
		}
	}

	int num = 0;
	bool isWork = true;
	int k = 0;
	while (isWork)
	{
		isWork = false;
		for (int i = k; i < columns - k; i++)
		{
			if (!boolMatrix[k][i])
			{
				boolMatrix[k][i] = true;
				out1 << matrix[k][i] << " ";
				isWork = true;
			}
		}
		for (int i = k + 1; i < line - k; i++)
		{
			if (!boolMatrix[i][columns - 1 - k])
			{
				boolMatrix[i][columns - 1 - k] = true;
				out1 << matrix[i][columns - 1 - k] << " ";
				isWork = true;
			}
		}
		for (int i = columns - k - 2; i >= k; i--)
		{
			if (!boolMatrix[line - 1 - k][i])
			{
				boolMatrix[line - 1 - k][i] = true;
				out1 << matrix[line - 1 - k][i] << " ";
				isWork = true;
			}
		}
		for (int i = line - 2 - k; i >= k + 1; i--)
		{
			if (!boolMatrix[i][k])
			{
				boolMatrix[i][k] = true;
				out1 << matrix[i][k] << " ";
				isWork = true;
			}
		}
		k++;
	}
	for (int i = 0; i < line; i++)
	{
		delete[]boolMatrix[i];
	}
	delete[]boolMatrix;
	out1.close();
}

void out2Func(int* matrix[], int columns, int line)
{
	ofstream out2("out2.txt", ios::out);
	for (int i = 0; i < line; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			if (matrix[i][j] != 0)
			{
				out2 << matrix[i][j] << " ";
			}
		}
	}
	out2.close();
}

void out3Func(int* matrix[], int columns, int line)
{
	ofstream out3("out3.txt", ios::out);
	for (int i = 0; i < line; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			out3 << matrix[i][j] * matrix[i][j] << " ";
		}
		out3 << endl;
	}
	out3.close();
}