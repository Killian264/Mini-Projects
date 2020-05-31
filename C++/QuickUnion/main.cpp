#include "QuickUnion.h"
#include <iostream>

// a simple helper function for testing that should probably be a QuickUnion method
void printConnected(int first, int second, QuickUnion* quickUnion){
    bool isConnected = quickUnion->connected(first,second);
    if(isConnected){
        cout << first << " is connected to " << second << endl;
        return;
    }
    cout << first << " is not connected to " << second << endl;

}

int main(int argc, char *argv[]){

    QuickUnion *quickUnion = new QuickUnion();

    quickUnion->printComponents();

}