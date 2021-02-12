#include<iostream>
using namespace std;
int main()
{
	int b;
	cout<<"Enter a number"<<"\n";
	cin>>b;
	int factorial=1;
	int i=1;
	while(b>=i)
	{
		factorial=factorial*b;
		b--;
	}
	cout<<"Factorial of number is="<<factorial;
}
