#include<iostream>
using namespace std;
int main()
{
	float l;
	float w;
	float Area;
	float Perimeter;
	
	cout<<"Enter Length of Rectangle"<<"\n";
	cin>>l;
	cout<<"Enter Width of Rectangle"<<"\n";
	cin>>w;

	Area=l*w;
	cout<<"Area of Rectangle is="<<Area<<"\n";
	
	Perimeter=2*(l+w);
	cout<<"Perimeter of Rectangle is="<<Perimeter<<"\n";

}
