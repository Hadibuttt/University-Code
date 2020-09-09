#include"stack.cpp"
#include<iostream>
using namespace std;

int main()
{
	int choice;
	stack<int> stackint;

	do {

		cout << "(I) Push " << endl;
		cout << "(II) Pop " << endl;
		cout << "(III) Tos " << endl;
		cout << "(IV) Isempty " << endl;
		cout << "(V) Isfull " << endl;
		cout << "(VI) Display " << endl;
		cout << "(VII) Exit " << endl;
		cout << "\n Enter Your Choice --> ";
		cin >> choice;

		switch (choice)
		{
		case 1:
			stackint.push();
			break;
		case 2:
			stackint.pop();
			break;
		case 3:
			stackint.tos();
			break;
		case 4:
			if (stackint.isfull())
			{
				cout << "\nQueue is full" << endl;
			}
			else
				cout << "\nQueue is not full" << endl;
			break;

		case 5:
			if (stackint.isempty())
			{
				cout << "\nQueue is empty" << endl;
			}
			else
				cout << "\nQueue is not empty" << endl;
			break;


		case 6:
			stackint.display();
			break;
		}
	} while (choice != 7);


	system("pause");
}