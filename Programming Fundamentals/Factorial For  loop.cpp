#include<iostream>
using namespace std;
int main()
{
	int a;
	cout<<"Enter Number Whose Factorial You Want to Print";
	cin>>a;
	int factorial=1;
	for(int i=1;a>=i;a--)
	{
		factorial=factorial*a;
	}
	cout<<"Factorial is="<<factorial;
}
