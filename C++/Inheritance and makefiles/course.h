#ifndef __COURSE__H__
#define __COURSE__H__

class course{
    public:
        course(void);
        course(char* building, char* instructor, int classroomNum);
        ~course(void);
        void printVariables(void);
    private:
        char building[25];
        char instructor[25];
        int classroomNum;

};


#endif