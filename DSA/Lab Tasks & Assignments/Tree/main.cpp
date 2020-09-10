#include <iostream>
#include"tree.h"
using namespace std;
int main() {
	tree t;
	int a, n;
	do {
		cout << "***************" << endl;
		cout << "1. BTS Creation " << endl;
		cout << "2. In order|Traversal|" << endl;
		cout << "3. Exit" << endl;
		cout << "***************" << endl;
		cout << "\n";
		cout << "Enter Your Choice" << endl;
		cin >> a;
		switch (a) {
		case 1:
			cout << "HOW MANY ELEMENTS YOU WANT TO ENTER" << endl;
			cin >> n;
			for (int i = 1; i <= n; i++) {
				t.insert();
			}
		case 2:
			t.display();
		case 3:
			cout << "Thank you for using our program!" << endl;
			//t.exit();

		}
	} while (a != 3);
	{

	}
}