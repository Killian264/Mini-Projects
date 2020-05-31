#include <cstddef>
#include "node.h"

// This is probably pointless but I like the shell


/**************************** PUBLIC: Constructor ****************************/
Node::Node(int new_data)
{
    data = new_data;
    next = NULL;
    prev = NULL;
}

/**************************** PUBLIC: setData ****************************/
// RETURN STATUS CODE
int Node::setData(int &new_data)
{
    p_setData(new_data);
    return 0;
}

/**************************** PUBLIC: setNext ****************************/
// RETURN STATUS CODE
int Node::setNext(Node *next_node_ptr)
{
   p_setNext(next_node_ptr);
   return 0;
}

/**************************** PUBLIC: setPrev ****************************/
// RETURN STATUS CODE
int Node::setPrev(Node *prev_node_ptr)
{
   p_setPrev(prev_node_ptr);
   return 0;
}

/**************************** PUBLIC: getData ****************************/
// RETURN DATA
int Node::getData()
{
    return p_getData();
}

/**************************** PUBLIC: getNext ****************************/
Node *Node::getNext()
{
    return p_getNext();
}

/**************************** PUBLIC: getPrev ****************************/
Node *Node::getPrev()
{
    return p_getPrev();
}




/**************************** PRIVATE: p_setData ****************************/
void Node::p_setData(int &new_data)
{
    data = new_data;
}

/**************************** PRIVATE: p_setNext ****************************/
void Node::p_setNext(Node *next_node_ptr)
{
   next = next_node_ptr;
}

/**************************** PRIVATE: p_setPrev ****************************/
void Node::p_setPrev(Node *prev_node_ptr)
{
   prev = prev_node_ptr;
}

/**************************** PRIVATE: p_getData ****************************/
int Node::p_getData()
{
    return data;
}

/**************************** PRIVATE: p_getNext ****************************/
Node *Node::p_getNext()
{
    return next;
}

/**************************** PRIVATE: p_getPrev ****************************/
Node *Node::p_getPrev()
{
    return prev;
}