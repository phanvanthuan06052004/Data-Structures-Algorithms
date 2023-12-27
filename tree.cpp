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

int findMaxElement(Tree root) {
    if (root == NULL) {
        cout << "Tree is empty." << endl;
        return INT_MIN; // Giả sử cây rỗng trả về giá trị INT_MIN
    }

    while (root->right != NULL) {
        root = root->right;
    }

    return root->data;
}

int findThirdLargestElement(Tree root) {
    if (root == NULL || (root->left == NULL && root->right == NULL)) {
        cout << "Tree does not have a third largest element." << endl;
        return INT_MIN; // Giả sử không tìm thấy trả về giá trị INT_MIN
    }

    if (root->right->right != NULL) {
        // Nếu có cây con phải, tìm giá trị lớn nhất trong cây con phải
        //if(root->right->right->right != NULL){
            while (root->right->right->right != NULL) {
                root = root->right;
            }
            // Trả về giá trị lớn nhất trong cây con phải (lớn thứ 2 trong toàn bộ cây)
            return root->data;
       // }
        
    } else {
        // Nếu không có cây con phải, tìm giá trị lớn thứ 2 trong cây (lớn nhất trong cây con trái)
        return findThirdLargestElement(root->left);
    }
}


int main(){
	Tree T;
	CreateTree(T);
	addNode(T,23);
	addNode(T,1);
	addNode(T,4);
	addNode(T,25);
	addNode(T,29);
	addNode(T,35);
	addNode(T,39);
	addNode(T,7);
	addNode(T,2);
	addNode(T,9);
	addNode(T,12);
	
	
	printTree(T);
	
	int thirdLargestElement = findThirdLargestElement(T);
    if (thirdLargestElement != INT_MIN) {
        cout << "Phan tu lon thu 3 trong cay: " << thirdLargestElement << endl;
    }
	
	return 0;
	
}
