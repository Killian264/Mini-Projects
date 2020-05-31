INCLUDE_DIRS := ./
CC := g++
CFLAGS := -I$(INCLUDE_DIRS)

list: main.o node.o list.o myException.o
	$(CC) -o list main.o node.o list.o myException.o $(CFLAGS)

list.o: list.cpp list.h
	$(CC) -c -o list.o list.cpp $(CFLAGS)

node.o: node.cpp node.h
	$(CC) -c -o node.o node.cpp $(CFLAGS)

myException.o: myException.cpp myException.h
	$(CC) -c -o myException.o myException.cpp $(CFLAGS)