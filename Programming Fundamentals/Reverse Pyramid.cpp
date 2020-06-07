#include<iostream>
using namespace std;
int main()
{
	float row;
	char c='A';
	cout<<"Enter Row";
	cin>>row;
for(int i=row;i>=1;i--)
	{
		for(int space=i;space<=row;space++)
		{
			cout<<" ";
		}
	for(int j=1;j<=(2*i-1);j++)
		{
			cout<<"*";
		}
		cout<<"\n";
	}
}
