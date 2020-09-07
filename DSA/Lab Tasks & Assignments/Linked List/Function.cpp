#include "list.h"
#include <iostream>
using namespace std;
void list::insertion() {


    newnode = new Node();
    size++;
    cout << "\nEnter Data to Store in Node # " << size << " : ";
    int x;
    cin >> x;
    newnode->setobj(x);
    newnode->setnext(nullptr);

    if (headnode == nullptr)
    {
        headnode = newnode;
        cn = newnode;
    }
    else
    {
        Node* temp;
        temp = headnode;
        while (temp != nullptr) {
            cn = temp;
            temp = temp->getnext();
        }
        cn->setnext(newnode);
        lcn = cn;
        cn = cn->getnext();
    }
    ci++;
    displaylist();
}

void list::displaylist() {

    if (size > 0) {
        Node* temp;
        temp = headnode;
        cout << "\nList ->";
        while (temp != nullptr)
        {
            cout << " " << temp->getobj();
            temp = temp->getnext();
        }
        cout << " <-";
    }
    else {
        cout << "< //////Empty List///// >";
    }
}
void list::back() {
    if (size > 1) {
        if (lcn != headnode) {
            Node* temp;
            temp = headnode;
            while (temp->getnext() != lcn) {

                temp = temp->getnext();
            }
            cn = lcn;
            lcn = temp;
            cout << "\nCurrent Index Backed Sucessfully \n";
            ci--;
        }
        else {


            cn = headnode;
            if (ci > 1) {
                ci--;
            }
            cout << "\n1st Node Reached" << endl;
        }
        cout << "Current Node = " << cn->getobj();
        cout << "\nLast Current Node = " << lcn->getobj();
    }
    else {
        cout << "Enter Atleast Two Numbers to Use Back";
    }
}

void list::imenu() {
    system("CLS");
    cout << "\n\n\n\n <<<<<<<<<<<<<<<<< Insertion Menu >>>>>>>>>>>>>>>>>>>>";
    cout << "\n\n\n | 1): New Node";
    cout << "\n | 2): Before the Location";
    cout << "\n | 3): After the Location";
    cout << "\n | 4): Next Index";
    cout << "\n | 5): Previous Index";
    cout << "\n | 6): Back";
    if (size > 0) {
        cout << "\n(Current_Location : " << ci << ") (Total Locations : " << size << " )\n";
        displaylist();
    }
    choice();
}

void list::choice() {
    cout << "\n\n\t\tEnter Your Choice : ->";
}

void list::ibf() {
    newnode = new Node();
    size++;
    cout << "\nEnter Data to Store in Node # " << size << " : ";
    int x;
    cin >> x;
    newnode->setobj(x);
    newnode->setnext(nullptr);
    if (size > 1) {
        if (cn != headnode) {
            ci++;
            newnode->setnext(lcn->getnext());
            lcn->setnext(newnode);
            cn = newnode;
        }
        else {
            newnode->setnext(headnode);
            headnode = newnode;
            lcn = newnode;

        }
    }
    else {
        cout << "First insert one node to use Before";
        insertion();
    }
}
void list::iaf() {
    newnode = new Node();
    size++;
    cout << "\nEnter Data to Store in Node # " << size << " : ";
    int x;
    cin >> x;
    newnode->setobj(x);
    newnode->setnext(nullptr);

    newnode->setnext(cn->getnext());

    cn->setnext(newnode);
    ci++;
    lcn = cn;
    cn = newnode;

}
void list::next() {
    if (size != 0)
    {
        if (cn->getnext() != nullptr) {
            ci++;
            lcn = cn;
            cn = cn->getnext();

        }
    }
    else {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }
}
int list::find() {
    if (size != 0)
    {

        displaylist();
        int flag = 0, value;
        cout << "Enter Number to Search from the list : ";
        cin >> value;
        Node* temp;
        Node* ltemp;
        temp = headnode;
        ltemp = headnode;
        ci = 1;
        while (temp != nullptr) {
            if (temp->getobj() == value)
            {

                flag = 1;
                cout << "Entered Number " << value << " is Found Successfully at index # : " << ci << endl;

                //lcn = ltemp;
                cn = temp;
                break;

            }
            else {
                temp = temp->getnext();
                // ltemp = temp;
                ci++;
            }
        }
        if (flag == 0)
        {
            cout << "Soory the Entered Number [ " << value << " ] is Not Found." << endl;
        }
        return flag;
    }
    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }
}
void list::deletetion() {
    if (size != 0)
    {

        int flag = find();
        Node* temp;
        temp = headnode;
        if (flag == 1)
        {
            lcn->setnext(cn->getnext());
            delete cn;
            cn = lcn->getnext();
            size--;

            cout << "Node Deleted Successfully\n";
            displaylist();

        }

    }

    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }
}

void list::get() {
    if (size != 0)
    {
        displaylist();
        cout << "\n\t<<<<<Fetched Element from Index # : " << ci << " = : " << cn->getobj() << " >>>>>>>>";
    }
    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }


}
void list::update() {
    if (size != 0)
    {


        if (find() == 1)
        {
            int value;
            cout << "\nEnter Element to be Updated in the List  : ";
            cin >> value;
            cn->setobj(value);
            cout << "\n \t\t*********List Successfully Updated*********\n";
            displaylist();
        }
    }
    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }

}


void list::start() {

    if (size != 0)
    {
        cn = headnode;
        lcn = headnode;
        cout << " Shifted to 1st node Sucessfully : " << headnode->getobj() << endl;
        ci = 1;
    }
    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }

}

//////////////////////////////////////////

void list::tail() {

    if (size != 0)
    {
        while (cn->getnext() != nullptr)
        {
            lcn = cn;
            cn = cn->getnext();
        }
        cout << "Shifted Successfully to Last Node :" << cn->getobj() << endl;

    }
    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }

}

void list::sizee() {

    if (size != 0)
    {
        cout << "Total Nodes Size  : " << size;
    }
    else
    {
        cout << "\n///////////Alert!!!Create Atlest One Node First///////" << endl;
    }

}