// Program described in class on 9/4/20
// Rules can be found in class video, short version here::
//   For G[x][y] ... add all neighbors & self to find sum
    //  In the next generation, value at [x][y] is
    //     sum % 10 == 0               0
    //     sum is under 50             add 3 to current
    //     sum between 50 & 150        subtract 3, but can't go below 0
    //     sum over 150                1
    // Any neighbors outside space are 0's
//
/*
Sample to illustrate rules:
A--
 1  2  3  4
 5  6  7  8
 9 10 11 12
13 14 15 16

B--
 4  5  0  7
 8  3  4 11
 6  0  8  9
16 11 12 13

*/


// this code does not work, but shows you how it should be structured

#include <stdio.h>
#include <stdlib.h>

// establish your sizes using variables or #define
//   so that it is easy to change;
// remainder of code should look at these values

int NR = 7;
int NC = 13;
int IT = 4;

// fill grid G with random values
// use srand(seed); to set the sequence
// use % high to restrict the range
int fillGrid( int G[][NC], int seed, int high ){
    srand(seed);

    for(int i = 0; i < NR; i++){
        for(int j = 0; j < NC; j++){
            if(!i || !j ||  (i == (NR - 1)) || (j == (NC - 1))){
                G[i][j] = 0;
            }
            else{
                G[i][j] = rand() % high;
            }
        }
    }
	return 0;
}

// print out the grid
void printGrid( int G[][NC] ){
    for(int i = 1; i < NR - 1; i++){
        for(int j = 1; j < NC - 1; j++){
            printf(" %3d ", G[i][j]);
        }
		printf("\n");
    }
	printf("\n");
}

// given grid, and an particular (x,y) location
//   compute the value of that spot in next generation
int checker( int arr[][NC],int x, int y ){
    int sum = 0;

	if(!x || !y || x == (NR - 1) || y == (NC - 1) ){
		return 0;
	}

    for(int i = -1; i <= 1; i++){
        for(int j = -1; j <= 1; j++){
            sum += arr[x + i][y + j];
        }
    }

    if(!sum % 10){
        return 0;
    }
  	if(sum < 50){
        return arr[x][y] + 3; 
    }
    if(sum < 150 && sum > 50) {
        int sub = (arr[x][y] - 3);
		return (sub > 0) ? sub : 0;
    }

    return 1;
}

void swap(int A[][NC], int B[][NC]){
	for(int i = 0; i < NR; i++){
		for(int j = 0; j < NC; j++){
			A[i][j] = B[i][j];
		}
	}
}

int main(){
    // 0 and NR/C - 2 are 0
    int A[NR][NC];
    int B[NR][NC];

    fillGrid( A, 29, 40 );

    printf("A--\n");
    printGrid(A);
	for (int x = 0; x < IT; x++) {

	    for (int i = 0; i < NR; i++ ){

	        for (int j = 0; j < NC; j++ ){
    	        B[i][j] = checker( A, i, j );
        	}
    	}

		swap(A, B);
		printGrid(A);
	}

    printGrid(B);
    return 0;
}