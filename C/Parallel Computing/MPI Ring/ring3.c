// MPI practice prorgram 9/30 

//for exactly 4 nodes
// pass the token around to each process
//  0 to 1 to 2 to 3 ... and back to 0

#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

void boss(int rank, int wsize, int N){
    int token = 0;
    for(long i = 0; i < N; i++){
        printf("TOKEN START: %d \n", token);
        MPI_Send(&token, 1, MPI_INT, 1, 0, MPI_COMM_WORLD);
        MPI_Recv(&token, 1, MPI_INT, wsize-1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        printf("--Proc %d of %d with token %d \n", rank, wsize - 1, token);
        token += 100; 
    }
}

void worker(int rank, int wsize, int N){
    int token = 0;
    for(long i = 0; i < N; i++){
        MPI_Recv(&token, 1, MPI_INT, rank - 1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        printf("--Proc %d of %d with token %d \n", rank, wsize - 1, token);
        MPI_Send(&token, 1, MPI_INT, (rank + 1) % wsize, 0, MPI_COMM_WORLD);
    }
}

int main(int argc, char* argv[])
{
	// Initialize the MPI environment
	MPI_Init(&argc, &argv);

	// Find out rank, size
	int rank;
	int wsize;
	MPI_Comm_rank(MPI_COMM_WORLD, &rank);
	MPI_Comm_size(MPI_COMM_WORLD, &wsize);

    float starttime = MPI_Wtime();

    int N = atoi(argv[1]);

    if ( rank == 0 )
    {
        boss(rank, wsize, N);
    }
    else
    {
        worker(rank, wsize, N);
    }

    float endtime   = MPI_Wtime();
    if(rank == 0){
        printf("MPI took %.1f seconds\n", rank, endtime-starttime);
    }
	MPI_Finalize();
	return 0;
}