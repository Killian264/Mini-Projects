#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <omp.h>


#define NR 20000
#define NC 20000
// SUBTRACT THE NUBMER OF ITERATIONS YOU WANT BY 1
#define IT 9
#define TR 12

int A[NR][NC];
int B[NR][NC];


int current;


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

	if(x <= 0 || y <= 0 || x >= (NR - 1) || y >= (NC - 1) ){
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

void dowork(){

	long myid = 0;
	int i;

	// Iterations
	for(int x = 0; x < IT; x++){
		// Do work
		// BEGIN WORK
		#pragma omp barrier
		
		
		i = 0;
		while(i < NR){
			#pragma omp critical
			{
				i = current;
				current++;
			}
			if(i < NR){
				for(int j = 0; j < NC; j++){
					B[i][j] = checker(A, i, j);
				}
			}
		}

		// END WORK
		#pragma omp barrier

		// BEGIN SWAP
		#pragma omp barrier
		
		i = 0;
		while(i < NR){
			#pragma omp critical
			{
				i = current;
				current++;
			}
			if(i < NR){
				for(int j = 0; j < NC; j++){
					A[i][j] = B[i][j];
				}
			}
		}
		// END SWAP
		#pragma omp barrier
	}
}

void logger(){
	for(int x = 0; x < IT; x++){
		// Set current to 0
		#pragma omp critical
		{
			current = 0;
		}

		// BEGIN WORK
		#pragma omp barrier

		// END WORK
		#pragma omp barrier

		#pragma omp critical
		{
			current = 0;
		}

		// BEGIN SWAP
		#pragma omp barrier

		printf("Generation: %d \n", x+2);
		// printGrid(B);

		// END SWAP
		#pragma omp barrier
	}
}

int main(){

	omp_set_num_threads(TR + 1);

    fillGrid( A, 2, 20 );

    printf("Generation: 1 \n");

    // printGrid(A);

	current = 0;

	#pragma omp parallel
	{
		int tid = omp_get_thread_num();
		if(tid == TR){
			logger();
		}
		else{
			dowork(tid);
		}
	}
    return 0;
}