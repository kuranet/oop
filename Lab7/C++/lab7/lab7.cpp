#include <iostream>
#include <time.h>   
#include"LinkedList.h"
#include"Node.h"

using namespace std;

int main()
{
	srand(time(NULL));

	LinkedList myList;

	for (int i = 0; i < 10; i++) {
		float n = (float)(rand() % 100) / 15;
		cout << "New node: " << n << endl;
		myList.AddAfterSecond(n);
		myList.PrintList();
	}
	int k = myList.FindCount(3.14f);

	myList.DeleteGreater();
	myList.PrintList();

	system("pause");
}
