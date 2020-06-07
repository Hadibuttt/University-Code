#include<iostream>
using namespace std;
int main()
{
	int salary,grade,bonus=1000;
	cout<<"Enter Salary"<<"\n";
	cin>>salary;
	cout<<"Enter grade"<<"\n";
	cin>>grade;
	if(grade>=15)
	{
		salary=salary+(bonus/2);
		cout<<"Salary is="<<salary<<"\n";
	}
	else if(grade<=15)
	{
		salary=salary+(bonus/4);
		cout<<"Salary is="<<salary<<"\n";
	}
	else
	{
		cout<<"Error";
	}
}
