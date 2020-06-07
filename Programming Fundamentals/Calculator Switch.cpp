#include<iostream>
using namespace std;
int main()
{
	int a,b;
	
	cout<<"Enter First Number"<<"\n";
	cin>>a;
	cout<<"Enter Second Number"<<"\n";
	cin>>b;
	char x;
	cout<<"Enter an Operator"<<"\n";
	cin>>x;
	switch(x)
	{
		case '+':
			cout<<"Sum is="<<a+b;
			break;
		
		case '*':
			cout<<"Product is="<<a*b;
			break;
		
		case '-':
			cout<<"Subtraction is="<<a-b;
			break;
		
		if(b>0)
		{
			case '/':
			cout<<"Division is="<<a/b;
			break;
		}

			default:
			cout<<"Error";
 	}	
}
