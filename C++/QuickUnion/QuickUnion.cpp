#include "QuickUnion.h"
#include <iostream>
#include <fstream>

using namespace std;

QuickUnion::QuickUnion(){
    this->createArray(15);

    // simple read in from file 

    fstream myInput;
    int inputCount, i, numFromFile = 0;

    myInput.open("input.txt", ios::in);
    myInput >> inputCount;
    this->createArray(inputCount);

    for( i = 0; i < inputCount; ++i ){
        myInput >> numFromFile;
        this->quickUnion(i, numFromFile);
    }

    myInput.close();
}
QuickUnion::~QuickUnion(){
    delete(this->components);
}

void QuickUnion::quickUnion(int first, int second){
    this->components[first] = second;
}

bool QuickUnion::connected(int first, int second){
    int firstRoot = this->findRoot(first);
    int secondRoot = this->findRoot(second);
    return firstRoot == secondRoot;
}
// loop through until the node connects to itself
int QuickUnion::findRoot(int start){
    int current = start;
    int currentVal = components[start];
    while(current != currentVal){
        current = currentVal;
        currentVal = components[current];
    }
    return current;
}

void QuickUnion::createArray(int size){
    this->numberOfItems = size;
    this->components = new int[size];
}

void QuickUnion::printComponents(void){
    for(int i = 0; i < numberOfItems; i++){
        cout << i << ": " << components[i] << endl;
    }
}