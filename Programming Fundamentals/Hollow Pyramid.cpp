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
		
		 for(int pace = i; pace < row; pace++)
         {cout << " ";
		 }
		for(int j=1;j<=(2*row-1);j++)
		{
			if(j==1||j==(2*row-1)||row==i)
			{
				cout<<"*";
			}
			
			else
			{
				cout<<" ";
			}
			cout<<"\n";
		}
	}
}
	
	
