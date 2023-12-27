#include<bits/stdc++.h>
using namespace std;
struct node{
	int data;
	node *next;	
};

int size(node *q){
	int cnt=0;
	while(q!=NULL){
		cnt++;
		q=q->next;
	}
	return cnt;
}
node *makeNode(int x){
	node *newNode = new node();
	newNode->data=x;
	newNode->next=NULL;
	return newNode;
}
void push(node *&q, int x){
	node *newNode = makeNode(x);
	if(q == NULL){
		q =newNode;	
		return;
	}
	node *tmp = q;
	while(tmp->next != NULL){
		tmp=tmp->next;
	}
	tmp->next=newNode;
}
bool empty(node *q){
	return q==NULL;
}

int front(node *q){
	return q->data;
}

void pop(node *&q){
	if(q==NULL)
		return;
	node *tmp=q;
	q=q->next;
	delete tmp;
}
void duyet(node *q){
	while(q!=NULL){
		cout<<q->data<<" ";
		q=q->next;
	}
}

int main(){
	node *q=NULL;
	while(1){
		cout<<"----------MENU------------"<<endl;
		cout<<"1. push"<<endl;
		cout<<"2. duyet"<<endl;
		cout<<"3. empty"<<endl;
		cout<<"4. pop"<<endl;
		cout<<"5. size"<<endl;
		cout<<"6. front"<<endl;
		cout<<"7. exit"<<endl;
		cout<<"----------MENU------------"<<endl;
		int lc; cin>>lc;
		if(lc==1){
			int x; cin>>x;
			push(q,x);
		}
		else 
			if(lc==2){
				duyet(q);
			}
			else
				if(lc==3){
					if(empty(q))
						cout<<"EMPTY!";
					else
						cout<<"NOT EMPTY";
				}
				else
					if(lc==4)
						pop(q);
					else
						if(lc==5)
							cout<<size(q)<<endl;
						else
							if(lc==6)
								cout<<front(q)<<endl;
							else
								break;
	}
	return 0;
}