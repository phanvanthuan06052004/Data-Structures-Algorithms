#include<bits/stdc++.h>
using namespace std;

struct node{
	int data;
	node *next;
};

node *makeNode(int x){
	node *newNode = new node();
	newNode->data=x;
	newNode->next=NULL;
	return newNode;
	
}
void push(node *&top, int x){
	node *newNode = makeNode(x);
	newNode->next = top;
	top = newNode;
}
int top1(node *top){
	return top->data; 
}
void pop(node *&top){
	if(top==NULL)
		return;
	node *tmp = top;
	top = top->next;
	delete tmp;
}
int size(node *top){
	int cnt=0;
	while(top!=NULL) {
		cnt++;
		top=top->next;
	}
	return cnt;
}
int main(){
	node *st=NULL;
	while(1){
		cout<<"---------------------------------"<<endl;
		cout<<"1. push\n";
		cout<<"2. pop\n";
		cout<<"3. top\n";
		cout<<"4. size\n";
		cout<<"5. exit\n";
		cout<<"---------------------------------"<<endl;
		int lc; cin>>lc;
		if(lc==1){
			int x; cin>>x;
			push(st,x);
		}
		else
			if(lc==2)
				pop(st);
			else
				if(lc==3)
					cout<<top1(st)<<endl;
				else
					if(lc==4){
						cout<<size(st)<<endl;
					}
					else
						break;					
	}
	return 0;
}