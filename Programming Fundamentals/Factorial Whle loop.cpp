#include<iostream>
using namespace std;
int main()
{
	int a;
	cout<<"Enter a number"<<"\n";
	cin>>a;
	int factorial=1;
	int i=1;
	while(a>=i)
	{
		factorial=factorial*a;
		a--;
	}
	cout<<"Factorial of number is="<<factorial;
}
