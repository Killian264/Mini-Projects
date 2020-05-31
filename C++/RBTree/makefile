INCLUDE_DIRS := ./
CC := g++
CFLAGS := -I$(INCLUDE_DIRS)

excRBTreeDel: main.o RBTree.o myException.o print.o
	$(CC) -o excRBTreeDel main.o RBTree.o myException.o print.o $(CFLAGS)

RBTree.o: RBTree.cpp RBTree.h
	$(CC) -c -o RBTree.o RBTree.cpp $(CFLAGS)


myException.o: myException.cpp myException.h
	$(CC) -c -o myException.o myException.cpp $(CFLAGS)

.PHONY: clean

clean:
		rm *.o excRBTreeDel
