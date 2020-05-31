INCLUDE_DIRS := ./
CC := g++
CFLAGS := -I$(INCLUDE_DIRS)

trie: main.o trie.o 
	$(CC) -o trie main.o trie.o   $(CFLAGS)

trie.o: trie.cpp trie.h
	$(CC) -c -o trie.o trie.cpp $(CFLAGS)



.PHONY: clean

clean:
		rm *.o trie
