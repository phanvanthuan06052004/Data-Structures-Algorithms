#include<bits/stdc++.h>
using namespace std;
struct node{
	int data;
	node *next;
};
struct aqueue{
	node *head;
	node *tail;
};
void createList(aqueue &l){
	l.head=NULL;
	l.tail=NULL;
}
node *makeNode(int x){
	node *tmp= new node();
	tmp->data=x;
	tmp->next=NULL;
	return tmp;
}
bool isEmpty(aqueue l){
	return l.head==NULL;
}
void enqueue(aqueue &l, int x){
	node *tmp=makeNode(x);
	if(l.head==NULL){
		l.head=tmp;
		l.tail=tmp;
	}
	else
	{
		l.tail->next=tmp;
		l.tail=tmp;
	}
}
void dequeue(aqueue &l){
	if(isEmpty(l))
		return;
	else{
		node *tmp=l.head;
		l.head=tmp->next;
		delete tmp;
		if(l.head==NULL)
			l.tail==NULL;
	}
}
int front(aqueue l){
	if(isEmpty(l))
		return 0;
	return l.head->data;
}
void in(aqueue l){
	node *tmp=l.head;
	while(tmp!=NULL){
		cout<<tmp->data<<" ";
		tmp=tmp->next;
	}
	cout<<endl;
}
int main(){
	aqueue l;
	createList(l);
	for(int i=0; i<10; i++){
		enqueue(l,i);
	}
	cout<<"danh sach hien tai: \n";
	in(l);
	bool ktr=isEmpty(l);
	if(ktr==true)
		cout<<"rong\n";
	else
		cout<<"ko rong\n";
	dequeue(l);
	cout<<front(l)<<endl;
	
}
