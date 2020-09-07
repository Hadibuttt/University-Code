#include "Node.h"
class list
{
	int* A;
	int max;
	int size = 0;
	int ci;
	Node* headnode;
	Node* cn;
	Node* lcn;
	Node* newnode;


public:

	void insertion();
	void displaylist();
	void back();
	void imenu();
	void choice();
	void ibf();
	void iaf();
	void next();
	int find();
	void deletetion();
	void update();
	void get();
	void tail();
	void start();
	void sizee();

	list() {
		headnode = nullptr;
		cn = nullptr;
		lcn = nullptr;
	}
	~list() {

	}

};