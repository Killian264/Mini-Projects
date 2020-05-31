#include <cstddef>
#include <iostream>
#include "course.h"
#include "computerCourse.h"
#include <string.h>
#include <cstdio>

using namespace std;


int main(){
    course theCourse("Alex", "Beacom", 117);
    theCourse.printVariables();
    char newarr[3][25] = {"VSCode", "KDBG", "gcc"};
    computerCourse theComputerCourse("Alex", "Beacom", 117, newarr);
    theComputerCourse.printVariables();
}