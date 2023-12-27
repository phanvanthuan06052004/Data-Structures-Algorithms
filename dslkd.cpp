#include<bits/stdc++.h>
using namespace std;
struct node{
	int data;
	node *next;
};
struct alist{
	node *head;
	node *tail;	
};
node *makeNode(int x){
	node *newNode = new node();
	newNode->data=x;
	newNode->next=NULL;
	return newNode;
}
void createList(alist &l){
	l.head=NULL;
	l.tail=NULL;
}
void printList(alist l){
	for(node *k =l.head; k!=NULL; k=k->next){
		cout<<k->data<<" ";
	}
}
node *findNodeX(alist l, int x){
//	for(node *k=l.head; k!=NULL; k=k->next){
//		if(k->data==x){
//			return k;
//		}
//		cout<<k->data<<" ";
//	}
//	return NULL;
	node *tmp=l.head;
	while((tmp != NULL) && (tmp->data != x)){
		tmp=tmp->next;
	}
	if(tmp!=NULL)
		return tmp;
	return NULL;
}

void addHead(alist &l, int x){
	node *p=makeNode(x);
	if(l.head==NULL){
		l.head=p;
		l.tail=p;
	}
	else{
		p->next=l.head;
		l.head=p;
	}
}
void addTail(alist &l, int x){
	node *newNode = makeNode(x);
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
void removeHead(alist &l){
	if(l.head==NULL)
		return;
	else
	{
		node *tmp = l.head;
		l.head=tmp->next;
		delete tmp;
	}
}
void length(alist l){
	int count=0;
	node *tmp = l.head;
	while(tmp != NULL){
		count++;
		tmp=tmp->next;
	}
	cout<<count;
}
void insertNode(alist &l, int x, int pos){
	node *p=makeNode(x);
	node *q = findNodeX(l,pos);
	if (q != NULL)
	{
		p->next = q->next;
		q->next = p;
		if (l.tail == q)
			l.tail = p;
	}
	else
		addHead(l,x);
	printList(l);
}
void detroyList(alist &l){
	node *tmp=l.head;
	while(tmp!=NULL){
		removeHead(l);
		tmp=l.head;
	}
	l.tail=NULL;
}
//xoa sau Node bat ki
void removeAfterQ(alist &l, int pos){
	node *q=findNodeX(l,pos);
	node *p=q->next;
	if(q!=NULL){
		if(p!=NULL){
			if(p==l.tail)
				l.tail=q;
			q->next=p->next;
			delete p;
		}
	}
}

int main(){
	alist l;
	createList(l);
	int pos;
	int x;
	while(1){
		cout<<"----------------------------\n";
		cout<<"1.findNodeX\n";
		cout<<"2.addHead\n";
		cout<<"3.insertNode\n";
		cout<<"4.printList\n";
		cout<<"5.addTail\n";
		cout<<"6.removeHead\n";
		cout<<"7.detroyList\n";
		cout<<"8.length\n";
		cout<<"9.removeAfterQ\n";
		cout<<"0.exit\n";
		cout<<"----------------------------\n";
		int lc; cin>>lc;
		if(lc==1){
			cin>>x;
			node* tmp = findNodeX(l,x);
			if(tmp!=NULL)
				cout<<"co x";
			else
				cout<<"ko thay!";
		}
		else
			if(lc==2){
				cin>>x;
				addHead(l,x);
			}
			else
				if(lc==3){
					cin>>x>>pos;
					insertNode(l,x,pos);
				}
				else
					if(lc==4){
						printList(l);
					}
					else
						if(lc==5){
							cin>>x;
							addTail(l,x);
							printList(l);
							
						}
						else
							if(lc==6){
								removeHead(l);
								printList(l);
							}
							else
								if(lc==7){
									detroyList(l);
									printList(l);
								}
								else
									if(lc==8){
										length(l);
									}
									else
										if(lc==9){
											cin>>pos;
											removeAfterQ(l,pos);
											printList(l);
										}
								else
									break;
	}
	return 0;
}