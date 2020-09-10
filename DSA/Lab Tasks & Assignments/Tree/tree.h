#include "TreeNode.h"
class tree {

private:
	int size;
	TreeNode* rootnode;
public:
	tree() {

		size = 0;
		rootnode = nullptr;
	}

	void insert();
	void display() {

	}
	//void exit() {}
	~tree() {
	}

};