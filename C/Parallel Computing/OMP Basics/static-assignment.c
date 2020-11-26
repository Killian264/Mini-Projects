#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>

#define N 9


int doworkSEQ(int k){
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
    int total = 0;
    for(int i = 1; i <= N; i++){
        total += doworkSEQ(i);
    }
    printf("%d", total);
}