class TreeNode {
public:
	// constructors
	TreeNode()
	{
		this->object = 0;
		this->left = this->right = nullptr;
	};
	TreeNode(int object)
	{
		this->object = object;
		this->left = this->right = nullptr;
	};
	int getInfo()
	{
		return this->object;
	};
	void setInfo(int object)
	{
		this->object = object;
	};
	TreeNode* getLeft()
	{
		return left;
	};
	void setLeft(TreeNode* left)
	{
		this->left = left;
	};
	TreeNode* getRight()
	{
		return right;
	};
	void setRight(TreeNode* right)
	{
		this->right = right;
	};
	int isLeaf()
	{
		if (this->left == nullptr && this->right == nullptr)
			return 1;
		return 0;
	};
private:
	int object;
	TreeNode* left;
	TreeNode* right;
};