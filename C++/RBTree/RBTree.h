#pragma once
#ifndef __RBTREE__H__
#define __RBTREE__H__

#include <iostream>

using namespace std;

typedef enum COLOR {
	BLACK,
	RED,
}COLOR;

typedef struct NODE {
	int value;
	NODE* LChild;
	NODE* RChild;
	NODE* parent;
	COLOR color;
}t_node;

class rbTree {
public:
	rbTree();
	~rbTree();

	int insertValue(int);
	int removeValue(int);
	void DumpTree(int);

private:
	t_node* root;
	int p_InsertValue(int);
	int p_RemoveValue(int);
	void p_DumpTree(t_node*, int);
	t_node* p_CreateNode(int);
	t_node* p_UpdateColors(t_node*);

	void p_RotateLeft(t_node*);
	void p_RotateRight(t_node*);

	void p_Transplant(t_node*, t_node*);

	void p_Delete(t_node*);

	void p_DeleteFixup(t_node*);

	t_node* p_findNode(int);

	t_node* p_treeMinimum(t_node*);

};

#endif