#include <iostream>
#include <fstream>

using namespace std;

void primAlgorithm(int **matrix, int vertex)
{
	bool *used = new bool[vertex];

	for (int i = 0; i < vertex; i++)
	{
		used[i] = false;
	}
	used[0] = true;

	int k = 0;
	int min = INT_MAX;
	int firstVertex = 0;
	int secondVertex = 0;
	while (k < vertex - 1)
	{
		min = INT_MAX;
		for (int i = 0; i < vertex; i++)
		{
			for (int j = 0; j < vertex; j++)
			{
				if (matrix[i][j] < min && used[i])
				{
					min = matrix[i][j];
					firstVertex = i;
					secondVertex = j;
				}
			}
		}

		if (!used[firstVertex] || !used[secondVertex])
		{
			cout << firstVertex + 1 << " " << secondVertex + 1 << " " << min << endl;
			used[secondVertex] = true;
			k++;
		}

		matrix[firstVertex][secondVertex] = INT_MAX;
		matrix[secondVertex][firstVertex] = INT_MAX;
	}
	delete []used;
}

void main()
{
	ifstream file("input.txt", ios::in);

	int vertex = 0;
	file >> vertex;

	int **matrix = new int*[vertex];

	for (int i = 0; i < vertex; i++)
	{
		matrix[i] = new int[vertex];
	}

	for (int i = 0; i < vertex; i++)
	{
		for (int j = 0; j < vertex; j++)
		{
			file >> matrix[i][j];
			if (matrix[i][j] == 0)
			{
				matrix[i][j] = INT_MAX;
			}
		}
	}
	file.close();

	cout << "Spanning tree by list(first vertex, second vertex and width): " << endl;
	primAlgorithm(matrix, vertex);

	for (int i = 0; i < vertex; i++)
	{
		delete []matrix[i];
	}
	delete []matrix;
	scanf("%*s");
}

/*
Test:
Input:
5
0 1 3 0 5
1 0 6 17 1
3 6 0 8 9
0 17 8 0 5
5 1 9 5 0
Output:
1 2 1
2 5 1
1 3 3
5 4 5
*/