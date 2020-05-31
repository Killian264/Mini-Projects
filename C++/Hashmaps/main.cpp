#include <iostream>
#include <fstream>
#include <unordered_map>

using namespace std;

/*
    Code Challenge 4
    Write a program that reads values from 'input.txt' and uses unordered maps and sets to track information
    about the values.

    'input.txt' has the following properties:
        * 1st line contains number of elements in file
        * * 20 means 20 elements, 50 means 50 elements.
        * 2nd line represents the maximum element in the list of numbers.
        * * 20 means the values will be between 0-19, and anything above or below is an error.
        * 3rd-nth line contain the numbers to insert.
    
    Goals:
        * Use an unordered_map to track how many times a number appears in 'input.txt'.
        * * The key will be the range of numbers possible, the value will be the count of the number
        * For each possible value in the range specified by 'input.txt', print the value and the number of times it appears.
    
    Example:
        input.txt contains:
            7
            10
            0
            5
            2
            8
            4
            5
            6
        The output of the program could be:
            2: 1 
            1: 0
            4: 1
            0: 1
            5: 2
            8: 1
            7: 0
            9: 0
            6: 1
            3: 0
*/

int main(int argc, char *argv[]){

    int inputCount, maxValue, currentInput;

    fstream myInput;

    unordered_map<int, int>* hashmap = new unordered_map<int, int>();

    unordered_map<int, int>::iterator mapIterator;

    myInput.open("input.txt", ios::in);
    myInput >> inputCount;
    myInput >> maxValue;

    for(int i = 0; i < inputCount; ++i ){
        myInput >> currentInput;
        if(hashmap->find(currentInput) == hashmap->end()){
            hashmap->insert(pair<int,int>(currentInput, 1));
        }
        else{
            mapIterator = hashmap->find(currentInput);
            hashmap->erase(currentInput);
            int add = mapIterator->second;
            add += 1;
            hashmap->insert(pair<int,int>(currentInput, add));
        }
        
    }
    myInput.close();

    for(mapIterator = hashmap->begin(); mapIterator != hashmap->end(); ++mapIterator){
        cout<<mapIterator->first<<" : "<<mapIterator->second<<endl;
    }
    
    return 0;
}