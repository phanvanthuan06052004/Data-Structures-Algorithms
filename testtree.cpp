#include<bits/stdc++.h>
using namespace std;

struct Node{
	int data;
	Node* left;
	Node* right;
};
typedef Node *Tree;

void CreateTree(Tree &root){
	root = NULL;
}
Node *makeNode(int x){
	Node *p = new Node;
	p->data = x;
	p->left = NULL;
	p->right = NULL;
	return p;
}
void addNode(Tree &root, int x){
	Node *tmp=makeNode(x);
	if(root){
		if(root->data == tmp->data)
			return;
		if(tmp->data <root->data)
			addNode(root->left, x);
		else
			addNode(root->right, x);
	}
	else{
		root = tmp;
	}
}
void printTree(Tree root){
	if(root){
		printTree(root->left);
		cout<<root->data<<" ";
		printTree(root->right);
	}
}



int main(){
	Tree T;
	CreateTree(T);
	
	addNode(T,1);
	addNode(T,4);
	addNode(T,7);
	addNode(T,2);
	printTree(T);
	return 0;
	
}