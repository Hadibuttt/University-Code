#include <iostream>
using namespace std;
#include "list.h"

int list::gmax() {
	if (max > 0)
		return 1;
	else {
		cout << " Please create a list first" << endl;
		return 0;
	}
}
int list::gsize() {
	if (size > 0)
		return 1;
	else {
		cout << " Insert elements in list first" << endl;
		return 0;
	}
}
void list::create() {
	if (max == 0)
	{
		cout << "Enter Max Size of list:" << endl;
		cin >> max;
		A = new int[max + 1];
	}
	else {
		cout << "Deallocate List First";
	}
}

void list::insert() {
	if (max == 0) {
		cout << " Please create a list first" << endl;
	}
	else {
		if (size == 0)
		{
			do {
				cout << "Enter size of list:" << endl;
				cin >> size;
				if (size > max || size < 1)
				{
					cout << "Invalid Size\n";
				}
			} while (size > max || size < 1);
			for (int a = 1; a <= size; a++) {
				cout << "Enter " << a << " number : " << endl;
				cin >> A[a];
				CI = a;
			}
		}

		else {
			if (size != max) {
				int value;
				cout << "Choose desired operation" << endl;
				cout << "1. By location" << endl;
				cout << "2. By value" << endl;
				cout << "Exit" << endl;
				cin >> value;
				switch (value) {
				case 1: {
					int option;
					cout << "You choose to insert by location" << endl;
					cout << "Choose desired operation" << endl;
					cout << "1. After current location" << endl;
					cout << "2. Before current location" << endl;
					cout << "3. At current location" << endl;
					cin >> option;
					switch (option)
					{
					case 1: //After current location
					{
						if (size != max) {

							for (int i = size; i >= CI + 1; i--)
							{
								A[i + 1] = A[i];
							}
							cout << "Enter value" << endl;
							cin >> A[CI + 1];
							size++;
							CI++;
						}
						else
						{
							cout << "Array is full";
						}
					}
					break;
					case 2: //Before current location
					{
						if (size != max) {
							if (CI > 1) {
								for (int i = size; i >= CI - 1; i--)
								{
									A[i + 1] = A[i];
								}
								cout << "Enter value" << endl;
								cin >> A[CI - 1];
								size++;
								CI--;
							}
							else {
								cout << "Soory You can't use before when current index= " << CI;
							}
						}
						else
						{
							cout << "Array is full";
						}
						break;
					}
					case 3: //At current location
					{
						if (size != max) {
							int value;
							cout << "Enter the value to insert at location #" << CI << " : " << endl;
							cin >> value;
							for (int i = size; i >= CI; i--)
								A[i + 1] = A[i];
							A[CI] = value;
							cout << "Value inserted successfully" << endl;
							size++;
						}

						else
						{
							cout << "Array is full";
						}
						break;
					}

					}
					break;
				}
				case 2:
				{
					int option2;
					do {
						cout << "You choose to insert by value" << endl;
						cout << "Choose desired operation" << endl;
						cout << "Press 1. After current value" << endl;
						cout << "Press 2. Before current value" << endl;
						cout << "Press 3. To close" << endl;
						cin >> option2;
						switch (option2)
						{
						case 1: {//after
							if (size != max) {
								if (find() == 1)
								{


									for (int i = size; i >= CI + 1; i--)
									{
										A[i + 1] = A[i];
									}
									cout << "Enter value" << endl;
									cin >> A[CI + 1];
									size++;
									CI++;
								}
							}
							else
							{
								cout << "Array is full";
							}

							break;
						}
						case 2: {//before
							if (size != max) {
								if (find() == 1)
								{
									if (CI > 1) {
										for (int i = size; i >= CI - 1; i--)
										{
											A[i + 1] = A[i];
										}
										cout << "Enter value" << endl;
										cin >> A[CI - 1];
										size++;
										CI--;
									}
									else {
										cout << "Soory You can't use before when current index= " << CI;
									}
								}
							}
							else
							{
								cout << "Array is full";
							}

							break;
						}
						case 3: {
							break;
						}
						default:
							break;
						}


					} while (option2 != 3);

					break;
				}

				case 3:
					cout << "Closing" << endl;
					break;
				default:
					cout << "Wrong Option try again" << endl;
				}
			}
			else { cout << "\nSorry!! List Is Full"; }
		}
		//////////////////

	}
}
void list::del() {
	if (size > 0) {
		int option3;
		do {
			cout << "You choose to delete a value" << endl;
			cout << "Choose desired operation" << endl;
			cout << "Press 1. To delete by current location " << endl;
			cout << "Press 2. To delete by value" << endl;
			cout << "Press 3. Back" << endl;
			cin >> option3;
			switch (option3) {
			case 1:
				cout << "You choose to delete by location" << endl;
				for (int i = CI; i < size; i++) {
					A[i] = A[i + 1];
				}
				size--;
				cout << "Successfully Deleted";
				if (CI > size) {
					CI = size;
				}

				break;

			case 2:
				int val;
				cout << "You choose to delete by value" << endl;
				if (find() == 1) {
					for (int i = CI; i < size; i++) {
						A[i] = A[i + 1];
					}
					size--;
					cout << "Successfully Deleted";
				}
				if (CI > size) {
					CI = size;
				}
				break;

			case 3:
	
			break;
			
			}
			
			} while (option3 > 3 || option3 < 1);
	}

}
void list::update() {

	if (find() == 1)
	{
		int up;
		cout << "Enter New Number to Update with " << A[CI] << " :";
		cin >> up;
		A[CI] = up;
		cout << "\n\t\t\tArray Updated...  Successfully " << endl;
	}
}
void list::start() {


	CI = 1;
	cout << "Index Shifted to Start at Index   " << CI;


}
void list::next() {
	if (CI < size) {
		CI++;
		cout << "NEXT\nCurrent index = " << CI;
	}
	else {
		cout << "You are already at last location " << CI << endl;
	}
}
void list::back() {
	if (CI > 1) {
		CI--;
		cout << "Back\nCurrent index = " << CI;
	}
	else {
		cout << "\nYou are already at first location " << CI;
	}
}
void list::tail() {
	if (max > 0) {
		if (size > 0) {
			CI = size;
			cout << "Index Shifted to Tail at Index   " << CI;
		}
	}
}
int list::find() {

	if (max == 0)
	{
		cout << "Create a List first" << endl;
	}
	else {
		int number;
		cout << "Enter number you want to find" << endl;
		cin >> number;
		int flag = 0;
		for (int i = 1; i <= max; i++) {
			if (number == A[i]) {
				flag = 1;
				CI = i;
				cout << "Number is at: " << CI << endl;
				break;
			}
			else {
				flag = 0;
			}
		}
		if (flag == 0) {
			cout << "Number is not found" << endl;
		}

		return flag;
	}
}
void list::get() {
	cout << "Displaying current index # " << CI << " " << "Value is:" << " " << A[CI] << endl;

}
void list::length() {
	cout << "The length of the list is: " << size << endl;
}
void list::displaylist() {
	if (size > 0)
	{
		cout << "Displaying the list" << endl;
		for (int i = 1; i <= size; i++) {
			cout << "Value is at Index" << " " << i << " " << "Value is: " << " " << A[i] << endl;
		}
	}
	else {
		cout << "Empty List";
	}
}
void list::deallocatelist() {
	delete[]A;
	size = 0;
	max = 0;
	CI = 0;
	cout << "\n List Deallocated";
}
int list::exit() {
	if (max > 0)
	{
		deallocatelist();
	}
	cout << "Closing the program press any key" << endl;
	return 0;
}
void list::copy() {
	int* B;
	B = new int[max + 1];
	for (int i = 1; i <= size; i++) {
		B[i] = A[i];
	}
	cout << "Sucessfully Copied";
}
void list::zero() {

	int temp = 1, count = 0;
	while (temp <= size) {
		if (A[temp] == 0)
		{
			count++;
		}
		temp++;
	}
	if (count > 0)
	{
		cout << "\n  " << count << " Zero Number Found ";
	}
	else {
		cout << "\n\t No Zero Number Found";
	}
}
