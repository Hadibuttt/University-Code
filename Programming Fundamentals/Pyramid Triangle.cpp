#include<iostream>
using namespace std;
int main()
{
	float row;
	char c='A';
	cout<<"Enter Row";
	cin>>row;
	for(int i=1;i<=row;i++)
	{
		for(int space=i;space<=row;space++)
		{
			cout<<" ";
		}
		for(int j=1;j<=(2*i-1);j++)
		{
			cout<<c;
			c++;
		}
		cout<<"\n";
	}
}
