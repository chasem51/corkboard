#ifndef MAJORS_H
#define MAJORS_H
#include <string>
#include <cstdlib>

using namespace std;
  
// Structure of a Node 
class Node
{ 
    public:
    string data; 
    Node *next; 
    Node *prev;
};

class LinkedList : public Node
{
    public:
    int length;
    //int total chrs;
   // int rem chrs;
    //int curr hubs;
  //  int rem hubs;

    Node *head = NULL;
    Node *end = NULL;
    LinkedList();
    ~LinkedList();
    void insertEnd(string value);
    void display(Node *head); 
};

bool search(string  value, Node *head, Node *head2); 


#endif
