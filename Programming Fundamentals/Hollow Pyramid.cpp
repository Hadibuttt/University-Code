#include<iostream>
using namespace std;
int main()
{
	float r;
	char c='A';
	cout<<"Enter Row";
	cin>>r;
	for(int i=1;i<=r;i++)
	{
		
		 for(int pace = i; pace < r; pace++)
         {cout << " ";
		 }
		for(int j=1;j<=(2*r-1);j++)
		{
			if(j==1||j==(2*r-1)||r==i)
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
	
	
