#include <iostream>
#include "list.h"
using namespace std;
int main()
{
	int op;
	list l;
	do {

		cout << "X----------x----------x----------X" << endl << endl;
		cout << "1. Create New" << endl;
		cout << "2. Insertion" << endl;
		cout << "3. Deletion" << endl;
		cout << "4. Update" << endl;
		cout << "5. Start" << endl;
		cout << "6. Next" << endl;
		cout << "7. Back" << endl;
		cout << "8. Tail" << endl;
		cout << "9. Find" << endl;
		cout << "10. Copy" << endl;
		cout << "11. Get" << endl;
		cout << "12. Size/Length" << endl;
		cout << "13. Dislpay " << endl;
		cout << "14. Count Zero" << endl;
		cout << "15. Deallocate" << endl;
		cout << "16. EXIT" << endl << endl;
		cout << "X----------x----------x----------X" << endl << endl;
		cin >> op;
		switch (op) {
		case 1:
		{
			l.create();
		}break;
		case 2:
		{
			l.insert();
		}break;
		case 3:
		{ if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.del();
			}
		}

		}break;
		case 4:
		{
			if (l.gmax() == 1)
			{
				if (l.gsize() == 1) {
					l.update();
				}
			}

		}break;
		case 5:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.start();
			}
		}

		}break;
		case 6:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.next();
			}
		}

		}break;
		case 7:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.back();
			}
		}

		}break;
		case 8:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.tail();
			}
		}

		}break;
		case 9:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.find();
			}
		}

		}break;
		case 10:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.copy();
			}
		}

		}break;
		case 11:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.get();
			}
		}

		}break;
		case 12:
		{if (l.gmax() == 1)
		{
			if (l.gsize() == 1) {
				l.length();
			}
		}

		}break;
		case 13:
		{if (l.gmax() == 1)
		{
			l.displaylist();
		}

		}break;
		case 14:
		{if (l.gmax() == 1)
		{
			l.zero();
		}

		}break;
		case 15:
		{if (l.gmax() == 1)
		{
			l.deallocatelist();
		}

		}break;
		case 16:
		{
			l.exit();
			break;
		}break;

		default:
		{
			cout << "invalid input" << endl;
		}
		}
	} while (op != 16);


}