#ifndef __COMPUTERCOURSE__H__
#define __COMPUTERCOURSE__H__

#include "course.h"

class computerCourse: public course{
    public:
        computerCourse(void);
        computerCourse(char* building, char* instructor, int classroomNum, char courses[3][25]);
        ~computerCourse(void);
        void printVariables(void);
    private:
        char courses[3][25];

};


#endif