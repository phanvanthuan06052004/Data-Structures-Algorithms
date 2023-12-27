#include <iostream>
#include <string>
using namespace std;

struct sinhvien {
    string name;
    double diem;
};

struct node {
    sinhvien s;
    node* next;
};

struct alist {
    node* head;
    node* tail;
};

void createList(alist& l) {
    l.head = NULL;
    l.tail = NULL;
}

node* makeNode(sinhvien s) {
    node* newNode = new node();
    newNode->s = s;
    newNode->next = NULL;
    return newNode;
}

void addHead(alist& l, sinhvien s) {
    node* newNode = makeNode(s);
    if (l.head == NULL) {
        l.head = newNode;
        l.tail = newNode;
    }
    else {
        newNode->next = l.head;
        l.head = newNode;
    }
}

void addTail(alist &l, sinhvien s){
	node* newNode = makeNode(s);
	if(l.head==NULL){
		l.head=newNode;
		l.tail=newNode;
	}
	else
	{
		l.tail->next=newNode;
		l.tail=newNode;
	}
}

void sortList(alist& l) {
    for (node* i = l.head; i != NULL; i = i->next) {
        for (node* j = l.head; j->next != NULL; j = j->next) {
            if (j->s.diem > j->next->s.diem) {
                sinhvien temp = j->s;
                j->s = j->next->s;
                j->next->s = temp;
            }
        }
    }
}

void duyet(alist& l) {
    for (node* k = l.head; k != NULL; k = k->next) {
        cout << k->s.name << " " << k->s.diem << endl;
    }
}

int main() {
    alist l;
    createList(l);
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        sinhvien s;
        cout << "nhap ten: \n";
        cin >> s.name;
        cout << "nhap diem: \n";
        cin >> s.diem;
        addHead(l, s);
    }
    sortList(l);
    duyet(l);
    return 0;
}
