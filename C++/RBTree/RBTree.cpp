#include "RBTree.h"
#include "myException.h"


rbTree::rbTree() {
	this->root = NULL;
}

rbTree::~rbTree() {

}

int rbTree::insertValue(int value) {
	this->p_InsertValue(value);
	return 1;
}

// Transplant routine 
void rbTree::p_Transplant(t_node* node, t_node* node2) {
	if (node->parent == NULL) {
		root = node2;
	}
	else if (node == node->parent->LChild) {
		node->parent->LChild = node2;
	}
	else {
		node->parent->RChild = node2;
		node2->parent = node->parent;
	}
}

// Minimum of a certain tree node not the root of the rbTree
t_node* rbTree::p_treeMinimum(t_node* root) {
	while (root->LChild != NULL) {
		root = root->LChild;
	}
	return root;
}

// Delete function
void rbTree::p_Delete(t_node* node) {
	// temp node
	t_node* nodeTemp = node;
	// original color
	COLOR nodeTempOrgColor = nodeTemp->color;
	// Case 1 LChild NULL
	if (node->LChild == NULL) {
		t_node* x = node->RChild;
		p_Transplant(node, node->RChild);
	}
	// Case 2 RChild NULL
	else if (node->RChild == NULL) {
		t_node* x = node->LChild;
		p_Transplant(node, node->LChild);
	}
	// Case 3 Double node neither child NULL
	else {
		nodeTemp = p_treeMinimum(node->RChild);
		nodeTempOrgColor = nodeTemp->color;
		t_node* x = nodeTemp->RChild;
		if (nodeTemp->parent == node) {
			x->parent = nodeTemp;
		}
		else {
			p_Transplant(nodeTemp, nodeTemp->RChild);
			nodeTemp->RChild = node->RChild;
			nodeTemp->RChild->parent = nodeTemp;
		}
		p_Transplant(node, nodeTemp);
		nodeTemp->LChild = node->LChild;
		nodeTemp->LChild->parent = nodeTemp;
		nodeTemp->color = node->color;
		// if its messed up fix it
		if (nodeTempOrgColor == BLACK) {
			p_DeleteFixup(x);
		}
	}
}

void rbTree::p_DeleteFixup(t_node* node) {
	if (node == NULL) {
		throw MyException("p_DeleteFixup: node is null.");
	}
	while (node != root && node->color == BLACK) {
		if (node == node->parent->LChild) {
			t_node* RChild = node->parent->RChild;
			// RChild case 1
			if (RChild->color == RED) {
				RChild->color = BLACK;
				node->parent->color = RED;
				p_RotateLeft(node->parent);
				RChild = node->parent->RChild;
			}
			// RChild case 2
			if (RChild->LChild->color == BLACK && RChild->RChild->color == BLACK) {
				RChild->color = RED;
				node = node->parent;
			}
			// RChild case 3
			else if (RChild->RChild->color == BLACK) {
				RChild->LChild->color = BLACK;
				RChild->color = RED;
				p_RotateRight(RChild);
				RChild = node->parent->RChild;
			}
			// RChild case 4
			RChild->color = node->parent->color;
			node->parent->color = BLACK;
			RChild->RChild->color = BLACK;
			p_RotateLeft(node->parent);
			node = root;
		}
		else {
			t_node* LChild = node->parent->LChild;
			// RChild case 1
			if (LChild->color == RED) {
				LChild->color = BLACK;
				node->parent->color = RED;
				p_RotateRight(node->parent);
				LChild = node->parent->LChild;
			}
			// RChild case 2
			if (LChild->RChild->color == BLACK && LChild->LChild->color == BLACK) {
				LChild->color = RED;
				node = node->parent;
			}
			// RChild case 3
			else if (LChild->LChild->color == BLACK) {
				LChild->RChild->color = BLACK;
				LChild->color = RED;
				p_RotateLeft(LChild);
				LChild = node->parent->LChild;
			}
			// RChild case 4
			LChild->color = node->parent->color;
			node->parent->color = BLACK;
			LChild->LChild->color = BLACK;
			p_RotateRight(node->parent);
			node = root;
		}
	}
	node->color = BLACK;
}
// find a node in a tree for delete function
t_node* rbTree::p_findNode(int value) {
	// go left/right depending on value to find node
	t_node* iter = this->root;
	while (iter != NULL) {
		if (iter->value == value) {
			return iter;
		}
		if (value > iter->value) {
			iter = iter->RChild;
		}
		else {
			iter = iter->LChild;
		}
	}
	throw MyException("p_findNode: node does not exist, value: " + value);
}

int rbTree::removeValue(int value) {
	this->p_Delete(p_findNode(value));
	return 1;
}

int rbTree::p_InsertValue(int value) {
	t_node* newNode = NULL;

	if (value < 1) {
		throw MyException("p_InsertValue: failed to insert: " + to_string(value) + " value is less than 0.");
	}

	try {
		newNode = this->p_CreateNode(value);
	}
	catch (MyException & exc) {
		throw MyException(exc.what());
	}

	if (this->root == NULL) {
		this->root = newNode;
		return 0;
	}
	 t_node* current = NULL;
	 t_node* next = this->root;

	 while(next != NULL){
	     current = next;

	     if(value == next->value){
	         throw MyException("p_InsertValue: failed to insert: " + to_string(value) + " value already exists in RBTree.");
	     }

	     if(value > next->value){
	         next = next->RChild;
	     }
	     else{
	         next = next->LChild;
	     }
	 }

	 if(value == current->value){
	     throw MyException("p_InsertValue: failed to insert: " + to_string(value) + " value already exists in RBTree.");
	 }
	 else if(current->value > value){
	     current->LChild = newNode;
	 }
	 else{
	     current->RChild = newNode;
	 }
	 newNode->parent = current;

	 while (newNode != this->root && newNode->parent->color == RED && newNode->color != BLACK)
	 {
		 t_node* parent = newNode->parent;
		 t_node* grandparent = newNode->parent->parent;

		 // if the grandparent exists
		 if (grandparent == NULL) {
			 return -1;
		 }

		 // CASE 1 AND CASE 2 THE RIGHT CASES
		 if (parent == grandparent->RChild)
		 {
			 t_node* uncle = grandparent->LChild;

			 // CASE 1 THE ONLY ONE WITH ONLY RECOLORING
			 if ((uncle != NULL) && (uncle->color == RED))
			 {
				 parent->color = BLACK;
				 uncle->color = BLACK;
				 grandparent->color = RED;
				 // set to colors in accordance with the rules found on geek for geeks
				 newNode = grandparent;
			 }
			 else
			 {
				 // RIGHT RIGHT
				 if (newNode == parent->LChild)
				 {
					 this->p_RotateRight(parent);
					 newNode = parent;
					 parent = newNode->parent;
				 }

				 // RIGHT LEFT
				 this->p_RotateLeft(grandparent);
				 // SHUFFLE COLORS
				 COLOR color = parent->color;
				 parent->color = grandparent->color;
				 grandparent->color = color;
				 newNode = parent;
			 }
		 }

		 // THE OTHER CASES IE THE LEFT CASES
		 if (parent == grandparent->LChild)
		 {
			 // grab uncle
			 t_node* uncle = grandparent->RChild;
			 // Case where uncle is red
			 // YOU must check if the uncle exists here as if it doesnt program will break as the uncle will not exist
			 // YOU also must check if uncle exists here as if it doesnt then it is black
			 // CASE 1 THE ONLY ONE WITH ONLY RECOLORING
			 if (uncle != NULL && uncle->color == RED)
			 {
				 parent->color = BLACK;
				 grandparent->color = RED;
				 uncle->color = BLACK;
				 // set to colors in accordance with the rules found on geek for geeks
				 newNode = grandparent;
			 }

			 else
			 {
				 // CASE 1 LEFT LEFT
				 if (newNode == parent->RChild)
				 {
					 this->p_RotateLeft(parent);
					 newNode = parent;
					 parent = newNode->parent;
				 }

				 // CASE 2 LEFT RIGHT
				 this->p_RotateRight(grandparent);
				 // SHUFFLE COLORS
				 COLOR color = parent->color;
				 parent->color = grandparent->color;
				 grandparent->color = color;
				 newNode = parent;
			 }
		 }
	 }
	 // THE ROOT must always be black thus I set it here
	 root->color = BLACK;

}

int rbTree::p_RemoveValue(int value) {
	return 1;
}

void rbTree::DumpTree(int indent) {
	this->p_DumpTree(this->root, indent);
}

t_node* rbTree::p_CreateNode(int value) {
	t_node* node = NULL;

	try {
		node = new t_node();
	}
	catch (bad_alloc & exc) {
		string errorInfo = string("p_CreateNode: ") + exc.what();
		throw MyException(errorInfo);
	}
	catch (exception & exc) {
		string errorInfo = string("General Error: ") + exc.what();
		throw MyException(errorInfo);
	}

	node->LChild = NULL;
	node->RChild = NULL;
	node->parent = NULL;
	node->color = RED;
	node->value = value;

	return node;

}


// left rotate around node
void rbTree::p_RotateLeft(t_node* node)
{
	// the right child this is a temp variable as the RChild will be switched out with the LeftChild
	t_node* RChildTEMP = node->RChild;
	// set the RChild of the node to the nodes Right Child's left child
	node->RChild = RChildTEMP->LChild;
	// if the right child exists set the right child's parent to the node this must be done as the right child was just set above
	if (node->RChild != NULL) node->RChild->parent = node;
	// set the parent of the right child to the parent of the node
	RChildTEMP->parent = node->parent;
	// if the node's parent is null set the root to the right child
	// remember that you know if a node is the root if it does not have a parent
	// thus we need to update the root pointer in out class
	if (node->parent == NULL) this->root = RChildTEMP;
	// if the node is the right child set the right child of the node to the RChild node we made above
	else if (node == node->parent->RChild)node->parent->RChild = RChildTEMP;
	// this gets the child that the node is not and sets it to the node we made above
	// if the node is the left child set the left child of the node to the RChild node we made above
	else if (node == node->parent->LChild) node->parent->LChild = RChildTEMP;
	// updating stuff
	RChildTEMP->LChild = node;
	node->parent = RChildTEMP;
}
// The comments on this function are the same as the comments are on the above one. This function is simply a flipped around version of the one above see that for more information
// right rotate around node
void rbTree::p_RotateRight(t_node* node)
{
	// the right child this is a temp variable as the RChild will be switched out with the LeftChild
	t_node* LChildTEMP = node->LChild;
	// set the RChild of the node to the nodes Right Child's left child
	node->LChild = LChildTEMP->RChild;
	// if the right child exists set the right child's parent to the node this must be done as the right child was just set above
	if (node->LChild != NULL) node->LChild->parent = node;
	// set the parent of the right child to the parent of the node
	LChildTEMP->parent = node->parent;
	// if the node's parent is null set the root to the right child
	// remember that you know if a node is the root if it does not have a parent
	// thus we need to update the root pointer in out class
	if (node->parent == NULL) this->root = LChildTEMP;
	// if the node is the right child set the right child of the node to the RChild node we made above
	else if (node == node->parent->RChild)node->parent->RChild = LChildTEMP;
	// this gets the child that the node is not and sets it to the node we made above
	// if the node is the left child set the left child of the node to the RChild node we made above
	else if (node == node->parent->LChild) node->parent->LChild = LChildTEMP;
	// updating stuff
	LChildTEMP->RChild = node;
	node->parent = LChildTEMP;
}