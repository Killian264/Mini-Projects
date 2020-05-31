#ifndef __LIST__H__
#define __LIST__H__

#include "node.h"

using namespace std;

class list{
    public:
        list();
        ~list();
        int appendValue(int);
        int deleteList(void);
        int printList(void);
        int removeValue(int);
        int sortList(void);
        int findValue(int);
        int printValue(int);

    private:
        int p_IsSorted;
        int p_NumberOfNodes;
        Node *p_Head;
        int p_SortList(void);
        Node* p_CreateNode(int);
        int p_DeleteList(void);
        int p_DeleteNode(int);
        int p_InsertNode(int);
        int p_PrintList(void);
        int p_FindValue(int);
        Node* p_GetValue(int);

};

#endif