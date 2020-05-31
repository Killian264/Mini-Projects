#include <iostream>
#include <fstream>
#include "RBTree.h"

using namespace std;

int main(int argc, char* argv[]) {
	// make tree here
	rbTree* tree = new rbTree();
	fstream myInput;
	int inputCount, i, numFromFile = 0;

	myInput.open("inputValues.txt", ios::in);
	myInput >> inputCount;

	for (i = 0; i < inputCount; ++i) {
		myInput >> numFromFile;
		tree->insertValue(numFromFile);
		// do stuff
	}
	myInput.close();


	//tree->DumpTree(4);
	//cout << endl;
	//cout << endl;


	tree->removeValue(33);
	tree->removeValue(70);
	tree->removeValue(50);
	tree->removeValue(20);

	tree->DumpTree(4);
	return 0;
}