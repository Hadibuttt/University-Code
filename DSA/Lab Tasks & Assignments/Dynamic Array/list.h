using namespace std;
class list {
public:
	int* A;
	int max;
	int size;
	int CI;


public:
	void create();
	void insert();
	void del();
	void update();
	void start();
	void next();
	void back();
	void tail();
	int find();
	void get();
	void length();
	void displaylist();
	void deallocatelist();
	int exit();
	void copy();
	void zero();
	int gsize();
	int gmax();
	list()
	{
		max = 0;
		size = 0;
		CI = 0;
	}
	~list() {

	}
};