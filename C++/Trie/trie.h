#pragma once
#ifndef __TRIE__H__
#define __TRIE__H__

#include <iostream>
#include <string>

using namespace std;

const int trieSizeConst = 26;

typedef struct NODE {
	struct NODE* children[trieSizeConst];
	bool isWord;
	int wordNumber;
}node;


class trie {
public:
	// Level 1
	trie();
	~trie();

	void insertWord(string word);

	bool locateWord(string word);

	void print();

	//Level 2
	void printWord(string word);

	// Level 3 
	bool deleteWord(string word);

	void deleteTrie();

	bool printWordAfterPrefix(string);

private:
	node* root;
	int wordCount;
	int trieSize = trieSizeConst;

	bool p_insertWord(string word);

	bool p_locateWord(string word);

	void p_print();

	void p_printHelper(node*,string);

	// Level 2
	bool p_printWord(string word);

	// Level 3
	bool p_deleteWord(string word);

	void p_deleteTrie();

	void p_deleteTrieHelper(node*);

	void p_insertNode(node*, int);

	node* p_createNode();

	bool p_childrenNULL(node*);

	bool p_deleteWordHelper(string, int, node*);

	bool p_printWordAfterPrefix(string);

};

#endif