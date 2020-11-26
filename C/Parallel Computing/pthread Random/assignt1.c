#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>

#define NUMT 8

void * evenThread( void *param){
	long N = (long) param;
	long sum = 0;
	for(int i = 1; i <= N; i++){
		sum += i;
	}
	pthread_exit((void *) sum);
}

void * oddThread( void *param){
	long N = (long) param;
	long sum = 1;
	for(int i = 1; i <= N; i++){
		sum *= i;
	}
	pthread_exit((void *) sum);
}

int main()
{
	pthread_t  tid[NUMT];

	for(long i = 1; i <= NUMT; i++ )
	{
		void* func = i % 2 ? oddThread : evenThread;
		pthread_create( &tid[i], NULL, func, (void *)i); 
	}

	void *retValue;
	long total = 0;

	for(long i = 1; i <= NUMT; i++){
		pthread_join( tid[i], &retValue);
		printf("Thread %d value %d\n", i, (long)retValue);
		total += (long)retValue;
	}

	printf("Total %d\n", total);

	pthread_exit(NULL);

	return 0;
}