#include "prec.h"
#include<conio.h>
using namespace std;

int main(int argc, char* argv[])
{
	Stackdeclare sd;
	int ch;

	do {
		cout << "-----Please Select Your Option-----" << endl;
		cout << "1.INPUT INFIX EXPRESSION" << endl;
		cout << "2.CONVERT INFIX TO POSTFIX" << endl;
		cout << "3.FINAL RESULT" << endl;
		cout << "4.EXIT" << endl;

		cout << "------CHOOSE AN OPTION------" << endl;

		while (true)
		{
			cin >> ch;
			if (cin.fail())
			{
				cin.clear();
				cout << "PLEASE ENTER AN INTEGER VALUE" << endl;
			}
			else
			{
				break;
			}
		}
		switch (ch)
		{
		case 1:
			sd.getexpression();
			break;
		case 2:
			sd.convert();
			break;
		case 3:
			sd.evaluate();
			break;
		case 4:
			cout << " Thank You For Using Our Program! " << endl;
			break;
		default:
			cout << "Error Wrong Pick!" << endl;
			break;
		}
	} while (ch != 4);

}