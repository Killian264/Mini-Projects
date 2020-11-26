#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <mpi.h>
#include <unistd.h>

#define HIGH1 25
#define HIGH2 35
#define THRESH 1
int NUMI  = 100000;

void FillArray(int arr[], int high){

    srand(time(NULL));

    for (int k = 0; k < NUMI; k++){
        arr[k] = rand() % high + 1;
    }
}

int diff(int a, int b){
    int ret = a > b ? a - b : b - a;  
    usleep(ret % 11 * 1500);
    return ret;
}

int largestDivisor(int a_in, int b_in){

    int a = b_in < a_in ? a_in : b_in; 
    int b = b_in >= a_in ? a_in : b_in;

    if(a_in <= 1 && b_in <= 1){
        return 1;
    }

    for(int i = a - 1; i > 0; i--){

        if(a % i == 1 || a % i <= THRESH){

            if(b % 1 == 1 || b % i <= THRESH){
                return i;
            }
        }
    }

    return -1;
}

void worker(int rank, int wsize, int N[], int M[], int P[], int Q[], int R[]){
    int chunk_size = NUMI / wsize;
    int section_start = chunk_size * (rank + 1) - chunk_size;

    srand(rank);

    int local_N[chunk_size];
    for(int i = section_start; i < section_start + chunk_size; i++){
        local_N[i - section_start] = rand() % HIGH1 + 1;
    }
    MPI_Allgather(&local_N, chunk_size, MPI_INT, N, chunk_size, MPI_INT, MPI_COMM_WORLD);

    int local_M[chunk_size];
    for(int i = section_start; i < section_start + chunk_size; i++){
        local_M[i - section_start] = rand() % HIGH2 + 1;
    }
    MPI_Allgather(&local_M, chunk_size, MPI_INT, M, chunk_size, MPI_INT, MPI_COMM_WORLD);

    int local_P[chunk_size];
    for(int i = section_start; i < section_start + chunk_size; i++){
        local_P[i - section_start] = diff(N[i], M[i]);
    }
    MPI_Allgather(&local_P, chunk_size, MPI_INT, P, chunk_size, MPI_INT, MPI_COMM_WORLD);

    int local_Q[chunk_size];
    for(int i = section_start; i < section_start + chunk_size; i++){
        local_Q[i - section_start] = largestDivisor(N[i], M[i]);
    }
    MPI_Allgather(&local_Q, chunk_size, MPI_INT, Q, chunk_size, MPI_INT, MPI_COMM_WORLD);

    int local_R[chunk_size];
    for(int i = section_start; i < section_start + chunk_size; i++){
        local_R[i - section_start] = largestDivisor(N[i], P[i]);
    }
    MPI_Allgather(&local_R, chunk_size, MPI_INT, &R, chunk_size, MPI_INT, MPI_COMM_WORLD);
}


void PrintArray(int arr[], char arrLet, int diff){

    printf("%c: ", arrLet);

    for (int k = 0; k < NUMI - diff; k++){
        
        printf("%2d ", arr[k]);
    }

    printf("\n");
}

int main(int argc, char* argv[]){
    // Initialize the MPI environment
	MPI_Init(&argc, &argv);

	// Find out rank, size
	int rank;
	int wsize;
	MPI_Comm_rank(MPI_COMM_WORLD, &rank);
	MPI_Comm_size(MPI_COMM_WORLD, &wsize);

    int diff = wsize - ( NUMI % wsize );
    if( diff == wsize){
        diff = 0;
    }
    NUMI += diff;

    float starttime = MPI_Wtime();
    int N[NUMI], M[NUMI], P[NUMI], Q[NUMI], R[NUMI];

    // FillArray(N, HIGH1);
    // FillArray(M, HIGH2);

    worker(rank, wsize, N, M, P, Q, R);

    float endtime   = MPI_Wtime();
    if(rank == 0){
        printf("MPI took %.1f seconds\n", rank, endtime-starttime);
        // PrintArray(N, 'N', diff);
        // PrintArray(M, 'M', diff);
        // PrintArray(P, 'P', diff);
        // PrintArray(Q, 'Q', diff);
        // PrintArray(R, 'R', diff);
    }
	MPI_Finalize();
    return 0;

}