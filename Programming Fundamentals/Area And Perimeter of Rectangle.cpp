#include<iostream>
using namespace std;
int main()
{
	float l;
	float w;
	float area;
	float perimeter;
	
	cout<<"Enter Length of Rectangle"<<"\n";
	cin>>l;
	cout<<"Enter Width of Rectangle"<<"\n";
	cin>>w;

	area=l*w;
	cout<<"Area of Rectangle is="<<area<<"\n";
	
	perimeter=2*(l+w);
	cout<<"Perimeter of Rectangle is="<<perimeter<<"\n";
}
