#include<iostream>
using namespace std;
int main()
{
	float m;
	float w;
	float Area;
	float Perimeter;
	
	cout<<"Enter Length of Rectangle"<<"\n";
	cin>>m;
	cout<<"Enter Width of Rectangle"<<"\n";
	cin>>w;

	Area=m*w;
	cout<<"Area of Rectangle is="<<Area<<"\n";
	
	Perimeter=2*(m+w);
	cout<<"Perimeter of Rectangle is="<<Perimeter<<"\n";

}
