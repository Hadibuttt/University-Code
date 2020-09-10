#include <iostream>
using namespace std;
#include "tree.h"
void tree::insert() {
	int info;
	TreeNode* node = new TreeNode();

	cout << "ENTER THE ELEMENT";
	cin >> info;

	node->setInfo(info);
	if (rootnode == nullptr) {
		rootnode = node;
		size++;

	}
	else {

		TreeNode* p, * q;
		p = q = rootnode;
		while (info != (p->getInfo()) && q != NULL)
		{
			p = q;
			if (info < (p->getInfo()))
				q = p->getLeft();
			else
				q = p->getRight();
		}
		if (info == (p->getInfo())) {
			cout << "attempt to insert duplicate: "
				<< info << endl;
			delete node;
		}
		else if (info < (p->getInfo())) {
			p->setLeft(node);
			size++;

		}
		else {
			p->setRight(node);
			size++;

		}
	}
}