#include<iostream>
using namespace std;
#include"stack.h"
#include<stdlib.h>	



template <class T>
stack<T>::stack()
{
	cout << "\n Enter Max Size of Array --> ";
	cin >> max;
	A = new T[max];
	top = -1;
}


template <class T>
stack<T>::~stack()
{
	delete[] A;
}


template <class T>
bool stack<T>::isempty()
{
	if (top == -1)
	{
		return true;
	}
	else
		return false;
}

template <class T>
bool stack<T>::isfull()
{
	if (top == max - 1)
	{
		return true;
	}
	else
		return false;
}


template <class T>
void stack<T>::push()
{

	if (!isfull())
	{
		T val;
		cout << "\n Enter number -->";
		cin >> val;
		A[++top] = val;
	}
	else
	{
		cout << "\nStack Overflow!!" << endl;
	}

}

template <class T>
T stack<T>::pop()
{
	T x;
	if (!isempty())
	{
		cout << "\n Popped Successfully  " << A[top] << " Out of the Stack " << endl;
		x = A[--top];
		return x;
	}
	else
	{
		cout << "\n Stack underflow!! " << endl;
		return 0;
	}
}

template <class T>
T stack<T>::tos()
{
	if (!isempty())
	{
		cout << "\n Top Element is: " << A[top] << endl;
		return A[top];
	}
	else
	{
		cout << "\n Stack underflow!! " << endl;
		return 0;
	}
}



template <class T>
void stack<T>::display()
{
	if (!isempty())
	{
		cout << "\n\tVALUES ARE: ";
		for (int i = 0; i <= top; i++)
		{
			cout << A[i] << " ";
		}
	}
	else
		cout << "\n Stack is empty!! " << endl;
}