#include "trie.h"
#include <string>
#include <exception>

using namespace std;

// Level 1
/**************************** PUBLIC: constructor ****************************/
trie::trie() {
	this->root = p_createNode();
	this->wordCount = 0;
}
/**************************** PUBLIC: destructor ****************************/
trie::~trie() {
	p_deleteTrie();
	delete(root);
}

/**************************** PUBLIC: insertWord ****************************/
void trie::insertWord(string word) {
	this->p_insertWord(word);
	return;
}

/**************************** PUBLIC: locateWord ****************************/
bool trie::locateWord(string word) {
	bool located = p_locateWord(word);
	if (located) cout << "Found word: " << word << endl;
	else cout << word << " was not found." << endl;
	return located;
}

/**************************** PUBLIC: print ****************************/
void trie::print() {
	p_print();
}

//Level 2
/**************************** PUBLIC: printWord ****************************/
void trie::printWord(string word) {
	p_printWord(word);
}

/**************************** PUBLIC: printWordAfterPrefix ****************************/
bool trie::printWordAfterPrefix(string prefix) {
	bool exists = p_printWordAfterPrefix(prefix);
	if (!exists) cout << "The prefix '" << prefix << "' does not exist" << endl;
	return exists;
}

// Level 3 
/**************************** PUBLIC: deleteWord ****************************/
bool trie::deleteWord(string word) {
	bool deleted = p_deleteWord(word);
	if (deleted) cout << "Deleted: " << word << endl;
	else cout << "word: " << word << " does not exist." << endl;
	return deleted;
}

/**************************** PUBLIC: deleteTrie ****************************/
void trie::deleteTrie() {
	this->p_deleteTrie();
}

/**************************** PRIVATE: p_insertWord ****************************/
bool trie::p_insertWord(string word) {

	node* iter = root;

	for (char letter : word) {
		int loc = (int)letter - 97;
		if (iter->children[loc] == NULL) {
			p_insertNode(iter, loc);
		}
		iter = iter->children[loc];
	}
	iter->isWord = true;
	iter->wordNumber = wordCount;
	wordCount++;
	return true;
}

/**************************** PRIVATE: p_locateWord ****************************/
bool trie::p_locateWord(string word) {
	node* iter = root;

	for (char letter : word) {
		int loc = (int)letter - 97;
		if (iter->children[loc] == NULL) {
			return false;
		}
		iter = iter->children[loc];
	}
	return iter->isWord;
}

/**************************** PRIVATE: p_print ****************************/
void trie::p_print() {
	string str;
	p_printHelper(root, str);
}

/**************************** PRIVATE: p_printHelper ****************************/
void trie::p_printHelper(node* parent, string str) {
	if (parent->isWord) {
		cout << "word: " << str << " " << parent->wordNumber << endl;
	}
	for (int i = 0; i < this->trieSize; i++) {
		if (parent->children[i] != NULL) {
			str.push_back((char)i + 97);
			p_printHelper(parent->children[i], str);
			str.pop_back();
		}
	}
}

/**************************** PRIVATE: p_printWordAfterPrefix ****************************/
bool trie::p_printWordAfterPrefix(string prefix) {
	node* iter = root;
	// check if prefix exists
	for (char letter : prefix) {
		int loc = (int)letter - 97;
		if (iter->children[loc] == NULL) {
			return false;
		}
		iter = iter->children[loc];
	}
	// string must start with prefix as print will start at the end of the prefix
	string str = prefix;
	p_printHelper(iter, str);

	return true;
}

// Level 2
/**************************** PRIVATE: p_printWord ****************************/
bool trie::p_printWord(string word) {
	node* iter = root;

	for (char letter : word) {
		int loc = (int)letter - 97;
		if (iter->children[loc] == NULL) {
			return false;
		}
		iter = iter->children[loc];
	}
	cout << "word: " << word << " " << iter->wordNumber << endl;
	return true;
}

// Level 3
/**************************** PRIVATE: p_deleteWord ****************************/
bool trie::p_deleteWord(string word) {
	if (!this->p_locateWord(word)) {
		return false;
	}
	else {
		p_deleteWordHelper(word, 0, root);
		return true;
	}
	wordCount--;
}

/**************************** PRIVATE: p_deleteWordHelper ****************************/
bool trie::p_deleteWordHelper(string word, int loc, node* iter) {
	bool NULLCheck = p_childrenNULL(iter);
	if (word.length() == loc) {
		if (NULLCheck) {
			delete(iter);
			return true;
		}
	}
	else {
		bool deleted = p_deleteWordHelper(word, loc + 1, iter->children[(int)word[loc] - 97]);
		if (deleted) {
			iter->children[(int)word[loc] - 97] = NULL;
			if (p_childrenNULL(iter) && !iter->isWord) {
				delete(iter);
				return true;
			}
			return false;
		}
		else {
			return deleted;
		}
	}
}

/**************************** PRIVATE: p_childrenNULL ****************************/
bool trie::p_childrenNULL(node* parent) {
	for (int i = 0; i < this->trieSize; i++) {
		if (parent->children[i] != NULL) {
			return false;
		}
	}
	return true;
}

/**************************** PRIVATE: p_deleteTrie ****************************/
// basically clearTrie
void trie::p_deleteTrie() {
	p_deleteTrieHelper(this->root);
	root = p_createNode();
	wordCount = 0;
}

/**************************** PRIVATE: p_deleteTrieHelper ****************************/
void trie::p_deleteTrieHelper(node* parent) {
	for (int i = 0; i < this->trieSize; i++) {
		if (parent->children[i] != NULL) {
			if (p_childrenNULL(parent->children[i])) {
				delete(parent->children[i]);
			}
			else {
				p_deleteTrieHelper(parent->children[i]);
			}
		}
	}
}

/**************************** PRIVATE: p_insertNode ****************************/
void trie::p_insertNode(node* parent, int loc) {
	if (loc > this->trieSize || loc < 0) {
        // I dont error handle in this application.
		//throw exception("p_createNode: location outside range of trie");
	}

	if (parent->children[loc] != NULL) {
		return;
	}
	else {
		node* child = p_createNode();
		parent->children[loc] = child;
		return;
	}
}

/**************************** PRIVATE: p_createNode ****************************/
node* trie::p_createNode() {
	NODE* child = new node;
	for (int i = 0; i < this->trieSize; i++) {
		child->children[i] = NULL;
	}
	child->isWord = false;
	return child;
}