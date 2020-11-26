#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <limits.h>

void generateList(int arr[], int N, int H, int rank){
    srand(rank);
    for(int i = 0; i < N; i++){
        arr[i] = rand() % H;
    }
}

void findData(int arr[], int N, int rank, int ret[3]){

    int section_start = N * (rank + 1) - N;

    int sum = 0;
    int max = arr[section_start];
    int min = arr[section_start];

    for(int i = section_start; i < section_start + N; i++){

        int curr = arr[i];
        if(curr < min)
            min = curr;

        if(curr > max)
            max = curr;

        sum += curr;
    }

    ret[0] = sum;
    ret[1] = max;
    ret[2] = min;
}


void boss(int rank, int wsize, int N, int H){

    int params[] = {N, H};

    MPI_Bcast(&params, 2, MPI_INT, 0, MPI_COMM_WORLD);


    int full_size = wsize * N;
    int full_array[full_size];

    // Boss is the same as the worker here to simplify things
    // it creates the same arrays and still does the work
    // but the work of boss is not factored into the result

    int local_list[N];
    generateList(local_list, N,H,rank);

    MPI_Allgather(&local_list, N, MPI_INT, &full_array, N, MPI_INT, MPI_COMM_WORLD);

    // Logging for testing
    // for(int i = 0; i < full_size; i++){
    //     if(i % N == 0)
    //         printf("\n");
    //     printf("%d, ", full_array[i]);
    // }

    int data_size = 3;

    int data[data_size];

    findData(full_array, N, rank, data);

    int all_data_size = data_size * wsize;
    int all_data[all_data_size];

    int local_sum = 0;
    int local_max = INT_MIN;
    int local_min = INT_MAX;

    int total_sum;
    int total_max;
    int total_min;

    MPI_Reduce(&local_sum, &total_sum, 1, MPI_INT, MPI_SUM, 0, MPI_COMM_WORLD);
    MPI_Reduce(&local_max, &total_max, 1, MPI_INT, MPI_MAX, 0, MPI_COMM_WORLD);
    MPI_Reduce(&local_min, &total_min, 1, MPI_INT, MPI_MIN, 0, MPI_COMM_WORLD);
    
    printf(" Array Sum: %d \n", total_sum);
    printf(" Array Max: %d \n", total_max);
    printf(" Array Min: %d \n", total_min);

}

void worker(int rank, int wsize){
    int params[2];
    MPI_Bcast(&params, 2, MPI_INT, 0, MPI_COMM_WORLD);

    int N = params[0];
    int H = params[1];

    int local_list[N];
    generateList(local_list, N, H,rank);

    int full_size = wsize * N;
    int full_array[full_size];

    MPI_Allgather(&local_list, N, MPI_INT, &full_array, N, MPI_INT, MPI_COMM_WORLD);

    int data_size = 3;

    int data[data_size];

    findData(full_array, N, rank, data);

    int all_data_size = data_size * wsize;
    int all_data[all_data_size];

    int local_sum = data[0];
    int local_max = data[1];
    int local_min = data[2];

    int total_sum;
    int total_max;
    int total_min;

    MPI_Reduce(&local_sum, &total_sum, 1, MPI_INT, MPI_SUM, 0, MPI_COMM_WORLD);
    MPI_Reduce(&local_max, &total_max, 1, MPI_INT, MPI_MAX, 0, MPI_COMM_WORLD);
    MPI_Reduce(&local_min, &total_min, 1, MPI_INT, MPI_MIN, 0, MPI_COMM_WORLD);
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

    int N = 10;
    int H = 5;

    if(argc == 3){
        N = atoi(argv[1]);
        H = atoi(argv[2]); 
    }

    if ( rank == 0 )
    {
        boss(rank, wsize, N, H);
    }
    else
    {
        worker(rank, wsize);
    }

    float endtime   = MPI_Wtime();
    if(rank == 0){
        printf("MPI took %.1f seconds\n", rank, endtime-starttime);
    }
	MPI_Finalize();
	return 0;
}