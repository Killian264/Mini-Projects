INCLUDE_DIRS := ./
CC := g++
CFLAGS := -I$(INCLUDE_DIRS)

codeChallenge3: main.o QuickUnion.o
	$(CC) -o codeChallenge3 main.o QuickUnion.o $(CFLAGS)

QuickUnion.o: QuickUnion.cpp QuickUnion.h
	$(CC) -c -o QuickUnion.o QuickUnion.cpp $(CFLAGS)

.PHONY: clean

clean:
	rm *.o QuickUnion