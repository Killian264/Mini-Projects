#include "list.h"
#include "myException.h"
#include "node.h"
#include <iostream>
#include <exception>
//#include <error-type>

/**************************** PUBLIC: Constructor ****************************/
/*
    Implementation hint(s): should initialize variables.
*/
list::list(void){
    this->p_Head = NULL;
    this->p_IsSorted = 0;
    this->p_NumberOfNodes = 0;
}

/**************************** PUBLIC: Destructor ****************************/
/*
    Implementation hint(s): Should ensure all dynamically allocated memory is deleted.
*/
list::~list(void){
    try{
       p_DeleteList(); 
    } catch(exception &exc){
        // turns out a destructor is no-exception so handling here is pointless

        // string errorInfo = string("Destructor: ") + exc.what();
        // throw MyException(errorInfo);
    }
}


/*****************************************************************************************/



/**************************** PUBLIC: appendValue ****************************/
/*
    Implementation hint(s): invoke relevant member functions to append value to end of list.
*/
int list::appendValue(int value){
    // call and handle
    try{
        this->p_InsertNode(value);
        return 0;
    }catch(MyException &exc){
        string errorInfo = string("appendValue: ") + exc.what();
        if(exc.getCode() == WARNING){
            cerr << exc.what() << endl;
            return -1;
        }
        throw MyException(errorInfo, exc.getCode());
        return -1;
    }
}

/**************************** PUBLIC: deleteList ****************************/
/*
    Implementation hint(s): invoke relevant member functions to delete the entire list.
*/
int list::deleteList(void){
    // call and handle
    int statusCode = -1;
    try{
        statusCode = this->p_DeleteList();
    } catch(MyException &exc){
        string errorInfo = string("deleteList: ") + exc.what();
        if(exc.getCode() == WARNING){
            cout << exc.what() << endl;
        }
        throw MyException(errorInfo, exc.getCode());
    }
    return statusCode;
}

/**************************** PUBLIC: printList ****************************/
/*
    Implementation hint(s): invoke relevant member functions to print the list to the screen. 
*/
int list::printList(void){
    // call and handle
    int statusCode = 0;
    try{
        statusCode = p_PrintList();
    }catch(MyException &exc){
        // depends on if you want to print informational or not
        if(exc.getCode() == WARNING || exc.getCode() == INFORMATIONAL){
            cout << exc.what() << endl;
        }
        throw MyException(exc.what(), exc.getCode());
        statusCode = -1;
    }
    return statusCode;
}

/**************************** PUBLIC: removeValue ****************************/
/*
    Implementation hint(s): invoke relevant member functions to delete value from list.
*/
int list::removeValue(int value){
    // call and handle
    int statusCode = -1;
    try{
        statusCode = this->p_DeleteNode(value);
    } catch(MyException &exc){
        string errorInfo = string("removeValue: ") + exc.what();
        if(exc.getCode() == WARNING){
            cout<<errorInfo<<endl;
        }
        throw MyException(errorInfo, exc.getCode());
    }
    return statusCode;

}

/**************************** PUBLIC: findValue ****************************/
int list::findValue(int target){
    // call and handle
    try{
        return this->p_FindValue(target);
    }catch(MyException &exc){
        throw MyException(exc.what(), exc.getCode());
    }
    return -1;
}

int list::printValue(int target)
{
    // call and handle
    try{
        int statusCode = this->p_FindValue(target);
        if(statusCode == target){
            return 0;
        }
    }catch(MyException &exc){
        throw MyException(exc.what(), exc.getCode());
    }
    return -1;
}

/**************************** PUBLIC: sortList ****************************/
/*
    Implementation hint(s): invoke relevant member functions to sort the list from smallest to largest.
*/
int list::sortList(void){
    // call and handle
    int statusCode = 0;
    try{
        statusCode = this->p_SortList();
        if(statusCode == -1){
            cout << "List is empty and cannot be sorted." << endl;
        }
    }catch(MyException &exc){
        if(exc.getCode() == ERROR){
            throw(exc);
        }
        statusCode = -1;
    }
    return statusCode;
}

/**************************** PRIVATE: sortList ****************************/
/*
    Implementation hint(s): invoke relevant member functions to sort the list from smallest to largest.
*/
int list::p_SortList(void){
    Node* itr; 
    Node* tail = NULL; 
    // counter to ensure all nodes are accounted for
    int i = 0;
    // should continue this activates if something is moved
    bool toContinue = true;

    // This should be handled in sortList and printed as a msg
    if (this->p_Head == NULL)
        return -1; 
  
    while(toContinue){
        // reset variables
        itr = this->p_Head; 
        toContinue = false;

        // I wrote this code back in CSC 150 for an assignment and didnt know what was wrong with it
        // I just realized that I am setting next here and that is breaking it
        // next = itr->getNext();

        // if you have seen bubblesort using an array this would be the j = array.length - i
        while (itr->getNext() != tail) 
        { 
            // if bigger switch values 
            if (itr->getData() > itr->getNext()->getData()) 
            {  
                toContinue = true;
                int itrData = itr->getData(); 
                int nextData = itr->getNext()->getData();
                itr->setData(nextData); 
                itr->getNext()->setData(itrData); 
            } 
            itr = itr->getNext(); 
        } 
        i += 1;
        tail = itr; 
    } 
    // thrown as exception as this should never happen unless the user switches Node info
    if(i > this->p_NumberOfNodes){
        throw MyException("List is missing element when it should not.", ERROR);
    }

    return 0;
}

/*****************************************************************************************/



/**************************** PRIVATE: p_CreateNode ****************************/
/*
    Implementation hint(s): invoke relevant member functions to create a node given a value.
*/
Node* list::p_CreateNode(int value){

    Node *curr = NULL;
    // alloc memory throw error if issue
    try{
        curr = new Node(value);
    } catch(bad_alloc &exc){
        string errorInfo = string("p_CreateNode: ") + exc.what();
        throw MyException(errorInfo, SYSTEM_FAILURE);
    } catch(exception &exc){
        string errorInfo = string("General Error: ") + exc.what();
        throw MyException(errorInfo, SYSTEM_FAILURE);
    }
    return curr;

}

/**************************** PRIVATE: p_DeleteList ****************************/
/*
    Implementation hint(s): invoke relevant member functions to delete the entire list.
*/
int list::p_DeleteList(void){
    // loop through nodes and remove them with delete node throw error if a deletion error occurs
    Node *toDelete = NULL;
    int retStatusCode = 0;
    // I use head here as if this messes up we need a pointer to delete the memory.
    while(this->p_NumberOfNodes != 0 && retStatusCode != -1){
        toDelete = this->p_Head;
        this->p_Head = p_Head->getNext();
        try{
            delete(toDelete);
        }catch(MyException &exc){
            throw MyException(string("p_DeleteList failed to delete node: "), SYSTEM_FAILURE);
        }
    }
    return retStatusCode;
}

/**************************** PRIVATE: p_DeleteNode ****************************/
/*
    Implementation hint(s): invoke relevant member functions to delete a given node.
*/
int list::p_DeleteNode(int target){
    // This check if the node exists using GetValue it also handles issues 
    Node* nodeToRemove = NULL;
    try{
        nodeToRemove = this->p_GetValue(target);
    }catch(MyException &exc){
        if(exc.getCode() == ERROR){
            throw MyException(exc.what(), exc.getCode());
        }
        cout<<exc.what()<<endl;
    }

    if(nodeToRemove == NULL){
        return -1;
    }

    // each of the different cases that exist

    if(this->p_NumberOfNodes == 1){
        this->p_Head = NULL;
    } 
    else if(nodeToRemove->getPrev() == NULL){
        this->p_Head = this->p_Head->getNext();
        this->p_Head->setPrev(NULL);
    } 
    else if(nodeToRemove->getNext() == NULL){
        Node* prev = nodeToRemove->getPrev();
        prev->setNext(NULL);
    } 
    else{
        Node* prev = nodeToRemove->getPrev();
        Node* next = nodeToRemove->getNext();
        prev->setNext(next);
        next->setPrev(prev);
    }

    // delete and handle error

    try{
        delete(nodeToRemove); 
    } catch(exception &exc){
        string errorInfo = string("p_DeleteNode: failed to delete node: ") + exc.what();
        throw MyException(errorInfo, SYSTEM_FAILURE);
    }
    this->p_NumberOfNodes -= 1;
    return 0;
    
}

/**************************** PRIVATE: p_InsertNode ****************************/
/*
    Implementation hint(s): invoke relevant member functions to insert a given value into the lis.
*/
int list::p_InsertNode(int value){

    if(0 >= value){
        throw MyException("Invalid value, cannot append to list.", WARNING);
        return -1;
    }

    Node *head = NULL;
    Node *newNode = NULL;
    bool exists = false;
    // check if value is already in list
    try{
        Node* node = this->p_GetValue(value);
        exists = true;
    }catch(MyException &exc){
        if(exc.getCode() == ERROR){
            throw MyException(exc.what(), exc.getCode());
        }
    }

    if(exists){
        throw MyException("Value already exists in list.", WARNING);
        return -1;
    }


    // Create node and handle issues

    try{
        newNode = this->p_CreateNode(value);
    }catch(MyException &exc){
        string errorInfo = string("p_insertNode: ") + exc.what();

        if(exc.getCode() == SYSTEM_FAILURE){
            throw MyException(errorInfo, SYSTEM_FAILURE);
        }
        if(exc.getCode() == WARNING){
            cout<<errorInfo<<endl;
        }
        return -1;
    }
    // append node
    if(this->p_Head == NULL){
        this->p_Head = newNode;
    } else{
        head = this->p_Head;
        head->setPrev(newNode);
        newNode->setNext(head);
        this->p_Head = newNode;
    }
    this->p_NumberOfNodes += 1;
    this->p_IsSorted = 0;
    return 0;
    

}

int list::p_PrintList(){
    // check if there is a list
    if(this->p_Head == NULL){
        throw MyException("List is missing element when it should not.", INFORMATIONAL);
    }else{
        // loop and print all nodes
        int i = 0;
        Node *itr = this->p_Head;
        while (itr != NULL)
        {
            cout << itr->getData() << " -> ";
            itr = itr->getNext();
            i++;
        }
        cout << "NULL" << endl;
        // if a node is missing throw an error
        if(i > this->p_NumberOfNodes){
            throw MyException("List is missing element when it should not.", ERROR);
        }
        return 0;
    }

}

int list::p_FindValue(int target){
    // this is simply a private handler of the findValue function as the GetValue returns a Node which should be private
    Node* ret = NULL;
    // Call and handle
    try{
        ret = this->p_GetValue(target);
        if(ret == NULL){
            return -1;
        }
        return ret->getData();
    }catch(MyException &exc){
        if(exc.getCode() == ERROR){
            throw MyException(exc.what(), exc.getCode());
        }
        cout<<exc.what()<<endl;
    }
    return -1;
}


Node* list::p_GetValue(int target){
    // loop and find the node then return it
    Node *itr = this->p_Head;
    int i = 0;
    while (itr != NULL)
	{
        if(itr->getData() == target)
            return itr;
        itr = itr->getNext();
        i++;
    }
    // throw exceptions if list is too small
    if(i > this->p_NumberOfNodes){
        throw MyException("List is missing element when it should not.", ERROR);
    }
    throw MyException("Node does not exist in list.", WARNING);
    return NULL;
}