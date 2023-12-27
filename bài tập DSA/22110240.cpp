#include<bits/stdc++.h>
using namespace std;
struct SinhVien{
	string name;
	double gpa;
	SinhVien(){
	}
	SinhVien(string ten, double diem){
		name = ten;
		gpa = diem;
	}
};
struct Node{
	SinhVien s;
	Node *next;
};
struct DS{
	Node *Head;
	Node *Tail;
};
void taoList(DS &l){
	l.Head=NULL;
	l.Tail=NULL;
}
Node *makeNode(SinhVien s){
	Node *newNode = new Node();
	newNode->s = s;
	newNode->next = NULL;
	return newNode;
}
void pushBack(DS &l, SinhVien s){
	Node *p= makeNode(s);
	if(l.Head == NULL){
		l.Head = p;
		l.Tail = l.Head;
	}
	else{
		l.Tail->next = p;
		l.Tail = p;
	}
}

void pushForn(DS &l, SinhVien s){
	Node *t= makeNode(s);
	if(l.Head == NULL){
		l.Head = t;
		l.Tail = t;
	}
	else{
		t->next = l.Head;
		l.Head = t;
	}
}
void inDS(DS l){
	Node *tmp=l.Head;
	if(tmp==NULL){
		cout<<"danh sach rong";
		return;
	}
	while(tmp != NULL){
		cout << tmp->s.name << " " << fixed << setprecision(2) << tmp->s.gpa << endl;
		tmp = tmp->next;
	}
}
void xoaSVDuoi5(DS &l){
	while( (l.Head != NULL) && (l.Head->s.gpa<5)){
		Node *tam = l.Head;
		l.Head = l.Head->next;
		delete tam;
	}
	Node *cn = l.Head;
	while((cn!=NULL) && (cn->next)){
		if(cn->next->s.gpa<5){
			Node *tmp = cn->next;
			cn->next = cn->next->next;
			delete tmp;
		}
		else{
			cn = cn->next;
		}
	}
}
Node *bubbleSort(Node *Head) {
    if (Head == NULL) {
        return NULL;
    }

    bool ktr;
    do {
        ktr = false;
        Node *p = NULL;
        Node *tmp = Head;

        while (tmp->next) {
            if (tmp->s.gpa > tmp->next->s.gpa) {
                if (p != NULL) {
                    p->next = tmp->next;
                } else {
                    Head = tmp->next;
                }

                Node *next = tmp->next->next;
                tmp->next->next = tmp;
                tmp->next = next;
                p = tmp;
                tmp = next;
                
                ktr = true;
            } else {
                p = tmp;
                tmp = tmp->next;
            }
        }
    } while (ktr);

    return Head;
}
void findMaxAndInsertFirst(DS &l) {
    l.Head = bubbleSort(l.Head);
	
    Node *max = l.Head;
    Node *tmp = l.Head;
    while (tmp->next) {
        max = tmp;
        tmp = tmp->next;
    }

    max->next = NULL;
    tmp->next = l.Head;
    l.Head = tmp;
}
void findMinAndInsertLast(DS &l) {
    if (l.Head == NULL || l.Head->next == NULL) {
        return;
    }

    Node *minNode = l.Head;
    Node *prevMin = NULL;
    Node *prev = l.Head;

    Node *tam = l.Head->next;

    while (tam) {
        if (tam->s.gpa < minNode->s.gpa) {
            minNode = tam;
            prevMin = prev;
        }

        prev = tam;
        tam = tam->next;
    }

    if (prevMin) {
        prevMin->next = minNode->next;
    } else {
        l.Head = minNode->next;
    }

    minNode->next = NULL;

    if (l.Tail) {
        l.Tail->next = minNode;
        l.Tail = minNode;
    } else {
        l.Head = l.Tail = minNode;
    }
}



int main(){
	DS l;
	taoList(l);
	SinhVien s("Teo", 6);
	SinhVien t("Ti", 3.8);
	SinhVien u("Long", 2);
	SinhVien v("Hai", 9);
	pushBack(l, s);
	pushBack(l, t);
	pushBack(l, u);
	pushBack(l, v);
	while(1){
		cout<<"Chon 1 neu ban muon xoa SV co diem CTDL <5. "<<endl;
		cout<<"chon 2 neu ban muon SV co diem CTDL cao nhat dung dau dnah sach."<<endl;
		cout<<"chon 3 neu ban muon SV co diem CTDL thap nhat dung cuoi danh sach"<<endl;
		cout<<"chon 4 de exit."<<endl;
		int n;
		cout<<"nhap yeu cau: "; cin>>n;
		if(n==1){
			xoaSVDuoi5(l);
			inDS(l);
		}
		else if(n==2){
			findMaxAndInsertFirst(l);
			inDS(l);
		}
		else if(n==3){
			findMinAndInsertLast(l);
			inDS(l);
		}
		else{
			break;
		}
	}
	return 0;
}