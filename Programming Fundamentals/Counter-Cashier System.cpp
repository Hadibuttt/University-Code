#include<iostream>
using namespace std;
int main()
{
	cout<<"\n"<<" ********************** WELCOME TO METRO CASH AND CARRY ********************** "<<"\n";
	cout<<"\n"<<"Please Select from the following options: "<<"\n";
	cout<<"\n"<<" 1. Start Billing"<<"\n"<<" 2. Employee Record"<<"\n"<<" 3. Metro Reviews"<<"\n"<<" 4. Exit";
	
	char choice,Again;
	int quantity[100];
	float price[100],total[100];
	string product[100];
	int p;
	int gtotal=0;
	int password;
	char name;
	
	do
	{
	cout<<"\n"<<"\n"<<"Enter your choice to proceed:"<<"\n";
	cin>>choice;
	
	switch (choice)
	{
		
		case '1':
			cout<<"Enter the Number of Purchased Products:"<<"\n";
			cin>>p;
			for(int i=1; i<=p;i++)
		{
				cout<<"Enter name of the "<<i<<" product: "<<"\n";
			cin>>product[i];
			cout<<"Enter Quantity of "<<i<<" product: "<<"\n";
			cin>>quantity[i];
			cout<<"Enter price of the "<<i<<" product: "<<"\n";
			cin>>price[i];
			total[i]=price[i]*quantity[i];
			gtotal=total[i]+gtotal;
		}
			cout<<"\n"<<" ------- Product Name -------- Quantity -------- Price -------- Total --------- "<<"\n";
			for(int b=1; b<=p;b++)
		{
			cout<<"\t"<<"\t"<<product[b]<<"\t"<<"\t"<<quantity[b]<<"\t"<<"\t"<<price[b]<<"\t"<<"\t"<<total[b]<<"\n";
		}
			cout<<" ------------------------------------------------------------------------------ "<<"\n";
			
			cout<<"Your Bill is="<<gtotal<<"\n";
			break;
		
		case '2':
			
			cout<<"Please Enter Sacred Metro Employee Passcode: "<<"\n";
			cin>>password;
			if(password==6969)
			{
			cout<<"Please Enter First Letter Of Designation (C,M,S): "<<"\n";
			cin>>name;
			
			switch (name)
			{
				case 'C':
					cout<<"\n"<<" ---- Cashier Name ---- Bills Conducted ---- Salary ---- Experience ---- "<<"\n";
					cout<<"\t"<<"Hadi Butt"<<"\t"<<"    "<<"12"<<"\t"<<"\t"<<"      "<<"18000/-"<<"      "<<"6 months"<<"\n";
					cout<<"\t"<<"Jazib Ali"<<"\t"<<"    "<<"06"<<"\t"<<"\t"<<"      "<<"15000/-"<<"      "<<"3 months"<<"\n";
					cout<<"\t"<<"Iqra Tahir"<<"\t"<<"    "<<"03"<<"\t"<<"\t"<<"      "<<"10000/-"<<"      "<<"1 months"<<"\n";
					cout<<" ------------------------------------------------------------------------- "<<"\n";
					break;				
				
				case 'M':
					cout<<"\n"<<" ---- Manager Name ---- Events Managed ---- Salary ---- Experience ---- "<<"\n";
					cout<<"\t"<<"Talha Butt"<<"\t"<<"    "<<"12"<<"\t"<<"\t"<<"      "<<"48000/-"<<"      "<<"2 years"<<"\n";
					cout<<"\t"<<"Kanza Ali"<<"\t"<<"    "<<"06"<<"\t"<<"\t"<<"      "<<"25000/-"<<"      "<<"6 months"<<"\n";
					cout<<"\t"<<"Aqeel Ijaz"<<"\t"<<"    "<<"03"<<"\t"<<"\t"<<"      "<<"15000/-"<<"      "<<"3 months"<<"\n";
					cout<<" ------------------------------------------------------------------------- "<<"\n";
					break;
			
				case 'S':
					cout<<"\n"<<" ---- Sweepers ---- Satisfaction ---- Salary ---- Experience ---- "<<"\n";
					cout<<"\t"<<"Martin Gill"<<"\t"<<"    "<<"100%"<<"\t"<<"8000/-"<<"      "<<"2 years"<<"\n";
					cout<<"\t"<<"Sophie Turner"<<"\t"<<"    "<<"69%"<<"\t"<<"\t"<<"5000/-"<<"      "<<"6 months"<<"\n";
					cout<<"\t"<<"Shazia Jamal"<<"\t"<<"    "<<"39%"<<"\t"<<"\t"<<"2500/-"<<"      "<<"3 months"<<"\n";
					cout<<" ------------------------------------------------------------------------- "<<"\n";
					break;
			}
			
			}
			
			else
			{
				cout<<"\n"<<"Invalid Input";
			}
			
			break;
		
		case '3':
					cout<<"\n"<<" ---- Customer Name ---- Rating ---- Feedback ---- Making Metro Better---- "<<"\n";
					cout<<"\t"<<"Hadi Mir"<<"\t"<<"    "<<"10/10"<<"\t"<<"Nice B.Music"<<"      "<<"Smoking Zone"<<"\n";
					cout<<"\t"<<"Jazib Ali"<<"\t"<<"    "<<"8/10"<<"\t"<<"Unique Decor"<<"      "<<"Masjid"<<"\n";
					cout<<"\t"<<"Iqra Tahir"<<"\t"<<"    "<<"6/10"<<"\t"<<"Neat and Tidy"<<"      "<<"Powder Room"<<"\n";
					cout<<" ------------------------------------------------------------------------- "<<"\n";
					break;
			
			break;
		
		case '4':
			break;
		
		default:
		cout<<"Invalid Choice";

	}

cout<<"\n"<<"Do you want to use program again Y/N?"<<"\n";
cin>>Again;
}while(Again=='Y');

cout<<"\n"<<" ********************** Thank You for Visting Metro! ********************** ";
}
