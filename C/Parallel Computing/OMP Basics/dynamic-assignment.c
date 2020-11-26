#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>
#include <omp.h>
#include <unistd.h>

#define N 20
#define T 5
int doworkSEQ(int k){
    sleep(k);
	if((k % 2) != 0){
        int factorial = 1;
        for(int i = 1; i <= k; i++){
            factorial *= i;
        }
        return factorial;
    }
    else{
        int sum = 0;
        for(int i = 1; i <= k; i++){
            sum += i;
        }
        return sum;
    }
}

int main(){
    omp_set_num_threads(T);
    int i;
    int total = 0;
    int work;

    #pragma omp parallel for schedule(dynamic) private(work)
    for(i = 1; i <= N; i++){
        work = doworkSEQ(i);
        #pragma omp critical
        {
            total += work;
        }
    }

    printf("%d", total);
}