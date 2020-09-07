class Node
{
	int object;
	Node* next;
public:
	Node() {
		object = 0;
		next = nullptr;

	}
	~Node() {

	}

	void setobj(int object)
	{
		this->object = object;
	}
	void setnext(Node* next)
	{
		this->next = next;
	}
	int getobj() {
		return object;
	}
	Node* getnext() {
		return next;
	}
};