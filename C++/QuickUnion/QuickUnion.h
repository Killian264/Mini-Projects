#ifndef __QUICKUNION__H__
#define __QUICKUNION__H__

#include "QuickUnion.h"

using namespace std;

class QuickUnion{
    public:
        QuickUnion();
        ~QuickUnion();
        void quickUnion(int,int);
        bool connected(int,int);
        int findRoot(int);
        void createArray(int);
        void printComponents(void);
        int numberOfItems;
        int* components;

    private:

};

#endif