#pragma once
#include <iostream>
using namespace std;
#include<string.h>
#include <ctype.h>
#include<stdlib.h>
template <class T>
class stack
{

private:
	int  top;
	T* nodes;
public:
	stack();
	int push(T&);
	T pop(void);
	int full();
	int empty();
	T Top();
	~stack();
	int MAXSTACKSIZE;
};

