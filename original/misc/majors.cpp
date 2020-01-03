#include "majors.h"
#include <iostream>

using namespace std; 
 

LinkedList :: LinkedList()
{
    this->length = 0;
    this->head = NULL;
}

LinkedList :: ~LinkedList()
{
    cout << "LIST DELETED." << endl;
}

// insert temp at the end of the linked list
void LinkedList::insertEnd(string value) 
{ 
    // If the list is empty, create a single node 
    if (this->head == NULL) 
    { 
        Node* temp = new Node(); 
        temp->data = value; 
        temp->next = temp->prev = this->head; 
        this->head = temp; 
        this->length++; 
        return; 
    } 
  
    // If list is not empty 
    Node *last = this->end;
  
    // Create Node
    Node *temp = new Node(); 
    temp->data = value; 
  
    // temp -> next points to head 
    temp->next = this->head; 
  
    // head points to temp for doubly linked insertion 
    this->head = temp; 
  
    this->length++;
} 

void LinkedList::display(Node *head) 
{ 
    // forward iterative print
    cout << "Traversal in forward direction:" << endl; 
    while (head != end) 
    { 
        cout << head->data << endl;
        head = head->next; 
    } 
} 

/*
// finds results matching an input value from start, store in second 'skipped' list start2
bool search(string value, LinkedList &list1, LinkedList &list2) 
{ 
    cout << "Searching for: " << value << endl;

    while(list1.head != NULL)
    {
        if(list1.head->data.find(value) != string::npos) // if temp -> data is equal to the value
        {
            list2.insertEnd(value);
            
            if(list1.head == list1.end)
            {  
                list2.display(list2.head);
                cout << "Number of courses matching the search: " << list2.length << endl;
                return 0;
            }
        }
        else if(list1.head == list1.end && list1.head->data.find(value) == string::npos) // if temp -> next is equal to start and temp -> data isn't equal to the value, search concluded
        {
            list1.end = NULL;
            cout << "Search returned no results." << endl;
            return 0;
        }
        list1.head = list1.head->next;  // iterate until value search is resolved
    }
} 
*/
  
int main() 
{ 
    /* Initialize empty list */
    LinkedList *list = new LinkedList();

    /* Initialize empty list */
    //LinkedList *list2 = new LinkedList();


    //Biomedical Engineering

    list->insertEnd("Biomedical Engineering"); 
  
    list->insertEnd("Required, CAS MA123, 4, ENG EK100, 0, CAS CH101, 4, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, CAS CH102, 4, ENG EK131, 2, ENG EK103, 3, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK210, 2, CAS WR150, 4, CAS MA226, 4, ENG BE209, 4, ENG EK301, 4, ENG EK381, 4, CAS BI315, 4, ENG BE403, 4, ENG BE403, 4, ENG BE491, 2, ENG EK424, 4, ENG BE 492, 2, ENG BE465, 2, ENG BE466, 4"); 

    list->insertEnd("Electives, One Continua & Fields Elective, Two Suitable Professional Electives, One Engineering elective, Two Biomedical engineering electives, One Biomedical engineering design elective");

    list->insertEnd("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

    //Computer Engineering
    list->insertEnd("Computer Engineering");

    list->insertEnd("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK327, 4, CAS MA226, 4, ENG EC311, 4, ENG EK301, 4, ENG EK210, 2, ENG EC330, 4, ENG EK381, 4, ENG EC413, 4, CAS MA193, 2, ENG EC463, 4, ENG EC464, 4");

    list->insertEnd("Electives, Two Core Electives, Two Computer Engineering Electives, One EE Breadth Elective, 3 Technical Electives");

    list->insertEnd("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

    //Mechaincal Engineering

    list->insertEnd("Mechanical Engineering");

    list->insertEnd("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG ME357, 2, CAS MA226, 4, ENG EC381, 4, ENG EK301, 4, ENG EK210, 2, ENG ME304, 4, ENG ME303, 4, ENG ME305, 4, ENG ME358, 2, ENG ME306, 4, ENG ME419, 4, ENG ME302, 4, ENG ME360, 4, ENG ME310, 4, ENG ME460, 4, ENG ME461, 4");

    list->insertEnd("Electives, Four Advanced Electives");

    list->insertEnd("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

    //Electrical Engineering

    list->insertEnd("Electrical Engineering");

    list->insertEnd("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK210, 2, CAS MA226, 4, CAS PY 313, 4, ENG EK301, 4, ENG EC455, 4, ENG EC401, 4, ENG EC311, 4, ENG EC311, 4, ENG EK381, 4, END EC 463, 4, ENG EC 464, 4");

    list->insertEnd("Electives, One Electronics Elective, One Systems Elective, One Electrophysics Elective, One Computer Elective, Three Technical Electives");

    list->insertEnd("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

    //

    cout << "Circular doubly linked list & its elements constructed." << endl; 
    
    list->display(list->head);
    
    cout << "Number of Majors: " << (list->length)/4 << endl;
    
    //search("Quantitiative Reasoning", &head, &list2);

    delete list;
    //delete list2;
  
    return 0; 
} 

  