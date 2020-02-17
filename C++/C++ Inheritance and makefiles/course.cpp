#include "course.h"
#include <iostream>
#include <string.h>

/****************************** PUBLIC: constructor ******************************/
course::course(void){
    strcpy(this->building, "");
    strcpy(this->instructor, "");
    this->classroomNum = -1;
}

/****************************** PUBLIC: constructor ******************************/
course::course(char* instructor, char* building,  int classroomNum){
    strcpy(this->building, building);
    strcpy(this->instructor, instructor);
    this->classroomNum = classroomNum;
}
/****************************** PUBLIC: destructor ******************************/
course::~course(){

}

/****************************** PUBLIC: printAllVariables ******************************/
void course::printVariables(void){
    std::cout << instructor << " " << building << " " << classroomNum << " ";
}