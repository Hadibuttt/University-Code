#include "list.h"
#include <iostream>
using namespace std;
int main() {

	int option;
	list b;
	do {
		cout << "\n\n\n\n******************List************************\n";
		cout << "1:Insertion\n";
		cout << "2:Deletion\n";
		cout << "3:Update\n";
		cout << "4:Start\n";
		cout << "5:Next\n";
		cout << "6:Back\n";
		cout << "7:Tail\n";
		cout << "8:Find\n";
		cout << "9:Get\n";
		cout << "10:Size\n";
		cout << "11:Display List\n";
		cout << "12:Exit\n";
		cout << "******************Choose an Option************************\n";
		cin >> option;
		switch (option)
		{

		case 1: {
			cout << "******************You Choosed************************\n\t\t";
			cout << "Insertion\n";
			int choice;
			system("CLS");
			do {
				b.imenu();
				cin >> choice;
				switch (choice)
				{
				case 1: {
					b.insertion();
					choice = 786;
					break;
				}
				case 2: {
					b.ibf();
					choice = 786;
					break;

				}
				case 3: {
					b.iaf();
					choice = 786;
					break;

				}
				case 4: {
					b.next();
					choice = 786;
					break;

				}
				case 5: {
					b.back();
					choice = 786;
					break;
				}
				case 6: {
					system("CLS");
					break;

				}
				default: {
					cout << "\n***********Invalid Choice||Please Select Option Between {1-6}************\n \t\t\t |Try Again|";
					break;
				}
				}


			} while (choice == 786 || choice < 0 || choice>6);




			break;
		}
		case 2: {
			cout << "******************You Choosed************************\n";
			cout << "Deletion\n";
			b.deletetion();
			break;

		}
		case 3: {
			cout << "******************You Choosed************************\n";
			cout << "Update\n";
			b.update();

			break;
		}
		case 4: {
			cout << "******************You Choosed************************\n";
			cout << "Start\n";
			b.start();
			break;
		}
		case 5: {
			cout << "******************You Choosed************************\n";
			cout << "Naxt\n";
			b.next();
			break;
		}
		case 6: {
			cout << "******************You Choosed************************\n";
			cout << "Back\n";
			b.back();
			break;
		}
		case 7: {
			cout << "******************You Choosed************************\n";
			cout << "Tail\n";
			b.tail();
			break;
		}

		case 8: {
			cout << "******************You Choosed************************\n";
			cout << "Find\n";
			b.find();
			break;
		}
		case 9: {
			cout << "******************You Choosed************************\n";
			cout << "Get\n";
			b.get();
			break;
		}
		case 10: {
			cout << "******************You Choosed************************\n";
			cout << "Size\n";
			b.sizee();
			break;
		}

		case 11: {
			cout << "******************You Choosed************************\n";
			cout << "Display List\n";
			b.displaylist();
			break;
		}

		case 12: {
			cout << "******************You Choosed To Exit************************\n";
			cout << "***********************Thank You !!!! Bye Bye\n\n";
			break;
		}
		default: {
			cout << "******************You Choosed Wrong Option************************\n";
			break;
		}
		}
	} while (option != 12);



	system("pause");
	return 0;
}