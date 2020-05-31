
#include <iostream>
#include <fstream>
#include "trie.h"

int main(int argc, char* argv[]) {
	trie* tri = new trie();
	fstream myInput;
	int inputCount;

	string currString;
	/**************************** Three point Read IN ****************************/
	cout << "Three input start -------------------------------------------------" << endl;
	myInput.open("threeInput.txt", ios::in);
	myInput >> inputCount;

	for (int i = 0; i < inputCount; ++i) {
		myInput >> currString;
		tri->insertWord(currString);
	}
	myInput.close();
	/**************************** Three point functions ****************************/
	tri->print();
	tri->locateWord("apple");

	tri->deleteTrie();

	/**************************** Four point Read IN ****************************/
	cout << "Four input start --------------------------------------------------" << endl;
	myInput.open("fourInput.txt", ios::in);
	myInput >> inputCount;

	for (int i = 0; i < inputCount; ++i) {
		myInput >> currString;
		tri->insertWord(currString);
	}
	myInput.close();

	/**************************** Four point functions ****************************/
	tri->printWord("banana");
	tri->printWord("cherry");
	tri->printWord("pears");

	tri->deleteTrie();

	/**************************** Five point Read IN ****************************/
	cout << "Five input start --------------------------------------------------" << endl;
	myInput.open("fiveInput.txt", ios::in);
	myInput >> inputCount;

	for (int i = 0; i < inputCount; ++i) {
		myInput >> currString;
		tri->insertWord(currString);
	}
	myInput.close();

	/**************************** Five point functions ****************************/

	tri->printWordAfterPrefix("t");
	tri->printWordAfterPrefix("b");

	tri->deleteWord("banana");
	tri->deleteWord("tests");

	tri->print();
	tri->deleteTrie();

	tri->~trie();

	return 0;
}
