#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>

#define NR 12
#define NC 20
// SUBTRACT THE NUBMER OF ITERATIONS YOU WANT BY 1
#define IT 9
#define TR 12

int A[NR][NC];
int B[NR][NC];

pthread_barrier_t barr;

pthread_mutex_t lock;

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

void * dowork(void * param){

	long myid = 0;
	int i;

	// Iterations
	for(int x = 0; x < IT; x++){
		// Do work
		// BEGIN WORK
		pthread_barrier_wait(&barr);
		
		
		i = 0;
		while(i < NR){
			pthread_mutex_lock(&lock);
				i = current;
				current++;
			pthread_mutex_unlock(&lock);
			if(i < NR){
				for(int j = 0; j < NC; j++){
					B[i][j] = checker(A, i, j);
				}
			}
		}

		// END WORK
		pthread_barrier_wait(&barr);

		// BEGIN SWAP
		pthread_barrier_wait(&barr);
		
		i = 0;
		while(i < NR){
			pthread_mutex_lock(&lock);
				i = current;
				current++;
			pthread_mutex_unlock(&lock);
			if(i < NR){
				for(int j = 0; j < NC; j++){
					A[i][j] = B[i][j];
				}
			}
		}
		// END SWAP
		pthread_barrier_wait(&barr);
	}
}

void* logger(void * param){
	for(int x = 0; x < IT; x++){
		// Set current to 0
		pthread_mutex_lock(&lock);
			current = 0;
		pthread_mutex_unlock(&lock);

		// BEGIN WORK
		pthread_barrier_wait(&barr);

		// END WORK
		pthread_barrier_wait(&barr);

		pthread_mutex_lock(&lock);
			current = 0;
		pthread_mutex_unlock(&lock);

		// BEGIN SWAP
		pthread_barrier_wait(&barr);

		printf("Generation: %d \n", x+2);
		printGrid(B);

		// END SWAP
		pthread_barrier_wait(&barr);
	}
}

int main(){

	pthread_t tid[TR + 1];

	pthread_barrier_init(&barr, NULL, TR + 1);

	pthread_mutex_init(&lock, NULL);

    fillGrid( A, 2, 20 );

    printf("Generation: 1 \n");

    printGrid(A);

	current = 0;

	// workers
	for(long i = 0; i < TR; i++){ 
		pthread_create(&tid[i], NULL, dowork, (void *) i);
	}
	// logger
	pthread_create(&tid[TR], NULL, logger, (void *) NULL);

	// join
	for(int i = 0; i < TR + 1; i++){
		pthread_join(tid[i], NULL);
	}

    return 0;
}
