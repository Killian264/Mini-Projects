import random

HIGH1 = 25
HIGH2 = 35
NUMI = 10
THRESH = 1


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



N = fillArray(NUMI, HIGH1)
M = fillArray(NUMI, HIGH2)

P = [diff(N[k], M[k]) for k in range(NUMI)]
Q = [largestDivisor(N[k], M[k]) for k in range(NUMI)]
R = [largestDivisor(N[k], P[k]) for k in range(NUMI)]

printArray(N, 'N')
printArray(M, 'M')
printArray(P, 'P')
printArray(Q, 'Q')
printArray(R, 'R')
