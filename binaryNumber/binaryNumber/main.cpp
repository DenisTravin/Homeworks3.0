#include <iostream>
#include <string>

using namespace std;

int makePow(int number, int pow)
{
	int result = 1;
	for (int i = 1; i < pow; i++)
	{
		result *= number;
	}
	return result;
}

void main()
{
	string strSource = "111111";
	int result = 0;
	int strLen = strSource.length();
	for (int i = strLen - 1; i >= 0; i--)
	{
		result += (strSource[i] -'0') * makePow(2, strLen - i);
	}
	printf("Decimal record of bin number is %i", result);
	scanf("%*s");
}