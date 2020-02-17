INCLUDE_DIRS := ./
CC := g++
CFLAGS := -I$(INCLUDE_DIRS)

codeChallenge1: main.o course.o computerCourse.o
	$(CC) -o codeChallenge1 main.o course.o computerCourse.o $(CFLAGS)

course.o: course.cpp course.h
	$(CC) -c -o course.o course.cpp $(CFLAGS)

computerCourse.o: computerCourse.cpp computerCourse.h
	$(CC) -c -o computerCourse.o computerCourse.cpp $(CFLAGS)