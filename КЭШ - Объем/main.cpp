#include<iostream>
#include<ctime>
#include <stdio.h>
#include <time.h>
using namespace std;


int main()
{
	int n = 1000000;
	char* arr = new char[n];
	for (int i = 0; i < n; i++)
	{
		arr[i] = 2;
	}

	unsigned long start = 0,
		end = 0,
		countJump = 0;

	double time = 0, 
		timeCash = 0;

	char var = 0;

	double LengthCash = 0;

	for (int i = 0; i < n; i++)
	{
		start = clock();

		var = arr[i];
		var += 5;
		arr[i] = var;

		end = clock();

		time = (double)(end - start) / CLOCKS_PER_SEC;
		if (timeCash < time)
		{
			countJump++;
		}
		timeCash = time;
	}
	LengthCash += n / countJump;

	cout << LengthCash * 8 << " bit" << endl;
	cout << LengthCash << " byte" << endl;
	cout << LengthCash / 1024 << " kb" << endl;


	system("pause");
	return 0;
}