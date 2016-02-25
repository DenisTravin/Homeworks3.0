#include <iostream>
#include <fstream>

using namespace std;

const int maxNumber = 100;

void print(int* matrix[], int vertex)
{
	for (int i = 0; i < vertex; i++)
	{
		for (int j = 0; j < vertex; j++)
		{
			cout << matrix[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl << endl;
}

int** setMatrix(int vertex)
{
	int **matrix = new int*[vertex];
	for (int i = 0; i < vertex; i++)
	{
		matrix[i] = new int[vertex];
	}
	for (int i = 0; i < vertex; i++)
	{
		for (int j = 0; j < vertex; j++)
		{
			matrix[i][j] = 0;
		}
	}
	return matrix;
}

void deleteMatrix(int* matrix[], int vertex)
{
	for (int i = 0; i < vertex; i++)
	{
		delete[]matrix[i];
	}
	delete[]matrix;
}

int getNearVertex(int* matrix[], int vertex, bool used[], int start, int minLength)
{
	int vertexTemp = -1;
	for (int i = 0; i < vertex; i++)
	{
		if (matrix[i][start] > 0 && !used[i])
		{
			if (matrix[i][i] == matrix[start][start])
			{
				used[i] = true;
				int newVertex = getNearVertex(matrix, vertex, used, i, minLength);
				if (newVertex != -1)
				{
					vertexTemp = newVertex;
				}
			}
			else
			{
				if (matrix[i][i] == 0)
				{
					int newLength = matrix[start][i];
					if (newLength < minLength)
					{
						minLength = newLength;
						vertexTemp = i;
					}
				}
			}
		}
	}
	return vertexTemp;
}

int getNearCityForCountry(int* matrix[], int vertex, int currentCountry)
{
	bool used[maxNumber] = {};
	for (int i = 0; i < vertex; i++)
	{
		if (matrix[i][i] - 1 == currentCountry)
		{
			used[i] = true;
			int minLength = INT_MAX;
			return getNearVertex(matrix, vertex, used, i, minLength);
		}
	}
}

void setCities(int* matrix[], int vertex, int k)
{
	int currentCountry = 0;
	int count = 0;
	while (count < vertex - k)
	{
		int newCity = getNearCityForCountry(matrix, vertex, currentCountry);
		if (newCity == -1)
		{
			currentCountry++;
			currentCountry = currentCountry % k;
			continue;
		}
		count++;
		matrix[newCity][newCity] = currentCountry + 1;
		currentCountry++;
		currentCountry = currentCountry % k;
		print(matrix, vertex);
	}
}

void printCountry(int* matrix[], int vertex, int currCountry)
{
	bool used[maxNumber] = {};
	for (int i = 0; i < vertex; i++)
	{
		if (!used[i] && matrix[i][i] - 1 == currCountry)
		{
			used[i] = true;
			cout << i + 1 << ' ';
		}
	}
}

void main()
{
	int n = 0;
	int m = 0;
	ifstream file("input.txt", ios::in);
	if (!file.is_open())
	{
		cout << "File don't found" << endl;
		scanf("%*s");
		return;
	}
	file >> n;
	file >> m;
	int** matrix = setMatrix(n);
	for (int k = 0; k < m; k++)
	{
		int i = 0;
		int j = 0;
		int len = 0;
		file >> i;
		file >> j;
		file >> len;
		matrix[i - 1][j - 1] = len;
		matrix[j - 1][i - 1] = len;
	}
	int k = 0;
	file >> k;
	for (int i = 0; i < k; i++)
	{
		int vertex = 0;
		file >> vertex;
		matrix[vertex - 1][vertex - 1] = i + 1;
	}
	file.close();
	print(matrix, n);
	setCities(matrix, n, k);
	for (int i = 0; i < k; i++)
	{
		cout << i + 1 << " country" << ": ";
		printCountry(matrix, n, i);
		cout << endl;
	}
	deleteMatrix(matrix, n);
	scanf("%*s");
}