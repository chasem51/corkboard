#include <iostream>
#include <string>
#include <cstdio>
#include "allcourses.h"
using namespace std; 
  
// insert new_node at the end of the linked list
void insertEnd(Node** head, string value) 
{ 
    // If the list is empty, create a single node 
    if (*head == NULL) 
    { 
        Node* new_node = new Node; 
        new_node->data = value; 
        new_node->next = new_node->prev = new_node; 
        *head = new_node; 
        return; 
    } 
  
    // If list is not empty 
    Node *last = (*head)->prev; 
  
    // Create Node
    Node *new_node = new Node; 
    new_node->data = value; 
  
    // new_node -> next points to head 
    new_node->next = *head; 
  
    // head -> prev points to new_node for doubly linked insertion 
    (*head)->prev = new_node; 
  
    // Make last previous of new node 
    new_node->prev = last; 
  
    // Make new node next of old last 
    last->next = new_node; 
} 
  
// insert new_node at the beginning of the linked list
void insertBegin(Node** head, string value) 
{ 
    // Pointer points to last Node 
    Node *last = (*head)->prev; 
  
   // create node
    Node *new_node = new Node; 
    new_node->data = value;
  
    // inserts new_node so its doubly linked
    new_node->next = *head; 
    new_node->prev = last; 
  
    // Update ptrs next and last
    last->next = (*head)->prev = new_node; 
  
    // Update head pointer 
    *head = new_node; 
}   
  
void display(Node* head) 
{ 
    Node *temp = head; 
  
    // forward iterative print
    cout << "Printed elements~" << endl;
    cout << "Traversal in forward direction:" << endl; 
    while (temp->next != head) 
    { 
        cout << temp->data << endl;
        temp = temp->next; 
    } 
    cout << temp->data << endl; 
  
    // backward iterative print
    cout << "Printed elements~" << endl;
    cout << "Traversal in reverse direction:" << endl; 
    Node *last = head->prev; 
    temp = last; 
    while (temp->prev != last) 
    { 
        cout << temp->data << endl; 
        temp = temp->prev; 
    } 
    cout << temp->data << endl; 
} 

// finds results matching an input value from start, store in second linked list start2
bool search(Node **head, Node **head2, string value) 
{ 
    // Node *temp = head;
    Node *last = (*head)->prev; 
    Node *temp = last->next;
     
    Node *temp2 = *head2;
    Node *last2 = temp2;

    cout << "Searching for: " << value << endl;

    while(temp != NULL)
    {
        if(temp->data.find(value) != string::npos) // if temp -> data is equal to the value
        {
           // cout << temp->data << endl;

            insertEnd(&temp2, temp->data);
            
            if(temp == last)
            {  
                display(temp2);
                return 0;
            }
        }
        else if(temp == last && temp->data.find(value) == string::npos) // if temp -> next is equal to start and temp -> data isn't equal to the value, search concluded
        {
            temp = NULL;
            cout << "Search returned no results." << endl;
            return 0;
        }
        temp = temp->next;  // iterate until value search is resolved
    }
} 

  
int main() 
{ 
    /* Initialize empty list */
    Node *start = NULL; 
    
    /* Initialize second list */
    Node *start2 = NULL;

    insertEnd(&start, "CAS, PY212, SI II, Quantitiative Reasoning Two, CT, T/C"); 
  
    insertEnd(&start, "CAS, PY211, SI I, Quantitiative Reasoning One, CT, T/C"); 

    insertBegin(&start, "ENG, EC327");
   
    cout << "Circular doubly linked list & its elements constructed." << endl; 
    display(start); 
    
    search(&start,&start2, "Quantitiative Reasoning");

   // display(start2);
  
    return 0; 
} 