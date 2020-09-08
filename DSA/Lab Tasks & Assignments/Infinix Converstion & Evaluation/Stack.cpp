#include"Stack.h"
#define CAPACITY 50


template <class T>
T stack<T>::pop()
{
	T x;
	if (top > -1)
	{
		x = nodes[top--];
		return x;
	}
	cout << "STACK UNDERFLOW" << endl;
	return 0;
};


template <class T>
stack<T>::~stack()
{
	delete nodes;
};

template <class T>
T stack<T>::Top()
{
	return nodes[top];
};



template <class T>
int   stack<T>::empty()
{
	if (top < 0)
	{
		return 1;
	}

	else
	{
		return 0;
	}
};

template <class T>
int  stack<T>::push(T& x)
{
	if (top < CAPACITY)
	{
		nodes[++top] = x;
		return 1;
	}
	cout << "STACK OVERFLOW" << endl;
	return 0;
};

template <class T>
stack<T>::stack()
{
	top = -1;
	nodes = new T[CAPACITY];
};

template <class T>
int stack<T>::full()
{
	if (top = MAXSTACKSIZE - 1)
		return 1;
};