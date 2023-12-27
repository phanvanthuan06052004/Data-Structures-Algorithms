#include<bits/stdc++.h>
using namespace std;
struct node{
	int data;
	node *next;
};
struct alist{
	node *head;
};
void createList(alist &l){
	l.head=NULL;
}
node *makeNode(int x){
	node *newNode= new node();
	newNode->data=x;
	newNode->next;
	return newNode;
}
void push(alist &l, int x){
	node *p=makeNode(x);
	if(l.head==NULL){
		l.head=p;
	}
	else{
		p->next=l.head;
		l.head=p;
	}
}
void pop(alist &l){
	if(l.head==NULL)
		return;
	else{
		node *p=l.head;
		l.head=p->next;
		delete p;
	}
}
bool isempty(alist l){
	return l.head==NULL;
}
int top(alist l){
	if(l.head==NULL)
		return 0;
	return l.head->data;
}
void in(alist l){
	node *p=l.head;
	while(l.head!=NULL){
		cout<<l.head->data<<" ";
		l.head=l.head->next;
	}
	cout<<endl;
}
int main(){
	alist l;
	createList(l);
	for(int i=0; i<10; i++){
		push(l,i);
	}
	cout<<"danh sach ban dau: ";
	in(l);
	bool ktr=isempty(l);
	if(ktr==true)
		cout<<"rong\n";
	else
		cout<<"ko rong\n";
	pop(l);
	
	cout<<top(l)<<endl;
	return 0;
	
}