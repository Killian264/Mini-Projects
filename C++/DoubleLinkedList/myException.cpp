#include "myException.h"

using namespace std;


/**************************** PUBLIC: Constructor ****************************/
MyException::MyException(void){
    this->errString = "Error: Something went wrong.";
}

/**************************** PUBLIC: Constructor ****************************/
MyException::MyException(const string &err, e_CODES code){
    this->code = code;
    this->errString = err;
}

/**************************** PUBLIC: Constructor ****************************/
MyException::MyException(const char *err, e_CODES code){
    this->code = code;
    this->errString = err;
}

/**************************** PUBLIC: retrieveError ****************************/
string MyException::retrieveError(void){
    this->errString = "\033[1;31m" + this->errString + "\033[0m";

    return this->errString;
}
/**************************** PRIVATE: retrieveCode ****************************/
e_CODES MyException::retrieveCode(void){
    return this->code;
}