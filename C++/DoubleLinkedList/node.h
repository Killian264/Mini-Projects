#ifndef __NODE__H__
#define __NODE__H__

class Node{
    public:
        Node(int data);
        int setData(int &new_data);
        int setNext(Node *next_node);
        int setPrev(Node *prev_node);
        int getData(void);
        Node *getNext(void);
        Node *getPrev(void);
    private:
        void p_setData(int &new_data);
        void p_setNext(Node *next_node);
        void p_setPrev(Node *prev_node);
        int p_getData(void);
        Node *p_getNext(void);
        Node *p_getPrev(void);

        int data;
        Node *next;
        Node *prev;
};


#endif