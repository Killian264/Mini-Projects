import random
import threading

HIGH1 = 25
HIGH2 = 35
NUMI = 10
THRESH = 1

NUMT = 12


def fillArray(size, high, seed=3):
    random.seed(seed)

    return [random.randrange(0, high) for i in range(size)]
    
def diff(a, b):
    return a - b if a > b else b - a

def largestDivisor(a_in, b_in):
    a = a_in if b_in < a_in else b_in
    b = a_in if b_in >= a_in else b_in

    if( a_in <= 1 and b_in <= 1 ):
        return 1

    for i in range( a - 1, 0, -1):
        if( a % i == 1 or a % i <= THRESH ):
            if( b % 1 == 1 or b % i <= THRESH ):
                return i

    return -1
    

def printArray(arr, arr_letter):
    print(f'{arr_letter}:', end="")

    for num in arr:
        print("%3d " % (num), end="")

    print()


def doWork(thread_count, thread_id, size, P, Q, R):

    for k in range(thread_id, size, thread_count):
        P[k] = diff(N[k], M[k])
        Q[k] = largestDivisor(N[k], M[k])
        R[k] = largestDivisor(N[k], P[k])

    return
    
    

# Ensure that thread doing this work is the main thread
if __name__ == "__main__":
    N = []
    M = []

    N = fillArray(NUMI, HIGH1)
    M = fillArray(NUMI, HIGH2)

    P = [-1 for k in range(NUMI)]
    Q = [-1 for k in range(NUMI)]
    R = [-1 for k in range(NUMI)]

    threads = []

    for i in range(NUMT):
        threads.append(threading.Thread(target=doWork, args=(NUMT, i, NUMI, P, Q, R)))
    
    for thread in threads:
        thread.start()

    for thread in threads:
        thread.join()


    printArray(N, 'N')
    printArray(M, 'M')
    printArray(P, 'P')
    printArray(Q, 'Q')
    printArray(R, 'R')
