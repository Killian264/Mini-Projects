#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int NR = 21;
int NC = 15;
// SUBTRACT THE NUBMER OF ITERATIONS YOU WANT BY 1
int IT = 14;

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

    if(!(sum % 10)){
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

    fillGrid( A, 79, 99 );

    printf("Generation: 1 \n");
    printGrid(A);
	for (int x = 0; x < IT; x++) {

	    for (int i = 0; i < NR; i++ ){

	        for (int j = 0; j < NC; j++ ){
    	        B[i][j] = checker( A, i, j );
        	}
    	}

		swap(A, B);
        printf("Generation: %d \n", x+2);
		printGrid(A);
	}
    return 0;
}
