#include "computerCourse.h"
#include "course.h"
#include <iostream>
#include <string.h>

/****************************** PUBLIC: constructor ******************************/
computerCourse::computerCourse(void){
    strcpy(this->courses[0], "");
    strcpy(this->courses[1], "");
    strcpy(this->courses[2], "");
}

/****************************** PUBLIC: constructor ******************************/
computerCourse::computerCourse(char* instructor, char* building, int classroomNum, char courses[3][25]) : course(instructor, building, classroomNum){
    strcpy(this->courses[0], courses[0]);
    strcpy(this->courses[1], courses[1]);
    strcpy(this->courses[2], courses[2]);
}
/****************************** PUBLIC: destructor ******************************/
computerCourse::~computerCourse(){

}

/****************************** PUBLIC: printVariables ******************************/
void computerCourse::printVariables(void){
    course::printVariables();
    for(int i = 0; i < 3; i++){
        std::cout << this->courses[i] << " ";
    }
}