#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define HIGH1 25
#define HIGH2 35
#define NUMI 10
#define THRESH 1

void FillArray(int arr[], int high){

    srand(time(NULL));

    for (int k = 0; k < NUMI; k++){
        arr[k] = rand() % high + 1;
    }
}

int diff(int a, int b){
    return a > b ? a - b : b - a;  
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

void PrintArray(int arr[], char arrLet){

    printf("%c: ", arrLet);

    for (int k = 0; k < NUMI; k++){
        
        printf("%2d ", arr[k]);
    }

    printf("\n");
}

int main(int argc, char* argv[]){
    int N[NUMI], M[NUMI], P[NUMI], Q[NUMI], R[NUMI];
    FillArray(N, HIGH1);
    FillArray(M, HIGH2);

    for (int k = 0; k < NUMI; k++){
        P[k] = diff(N[k], M[k]);
        Q[k] = largestDivisor(N[k], M[k]);
        R[k] = largestDivisor(N[k], P[k]);
    }

    PrintArray(N, 'N');
    PrintArray(M, 'M');
    PrintArray(P, 'P');
    PrintArray(Q, 'Q');
    PrintArray(R, 'R');

    return 0;

}