//*********************INCLUDE GUARD*********************
#ifndef __MY_EXCEPTION_H__
#define __MY_EXCEPTION_H__
//*********************INCLUDE GUARD*********************

//*********************REQUIRED INCLUDES*********************
#include <exception>
#include <string>
//*********************REQUIRED INCLUDES*********************

using namespace std;

// Enum codes used to decide fate of exception

typedef enum CODES{
    INFORMATIONAL,
    WARNING,
    ERROR,
    SYSTEM_FAILURE,
}e_CODES;



//*********************START CLASS MyException DEFINITION*********************
class MyException : public exception {
    public:
        MyException(void);
        MyException(const char*, e_CODES);
        MyException(const string&, e_CODES);
        virtual const string what(){
            return this->retrieveError();
        }
        virtual const e_CODES getCode(){
            return this->retrieveCode();
        }
    private:
        string errString;
        string retrieveError(void);
        e_CODES code;
        e_CODES retrieveCode(void);

};
//*********************END CLASS MyException DEFINITION*********************

#endif