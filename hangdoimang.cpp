#include<bits/stdc++.h>
using namespace std;
int n=0;
int maxn=1000;
int A[1000]; 

int size(){
	return n;
}
void push(int x){
	if(n==maxn)
		return;
	A[n]=x; 
	n++;
}
bool empty(){
	return n==0;
}

int front(){
	return A[0];
}

void pop(){
	if(n==0)
		return;
	for(int i=0; i<n-1; i++){
		A[i]=A[i+1];
	}
	n--;
}

int main(){
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
			push(x);
		}
		else 
			if(lc==2){
				for(int i=0; i<n; i++)
					cout<<A[i]<<" ";
			}
			else
				if(lc==3){
					if(empty())
						cout<<"EMPTY!";
					else
						cout<<"NOT EMPTY";
				}
				else
					if(lc==4)
						pop();
					else
						if(lc==5)
							cout<<size()<<endl;
						else
							if(lc==6)
								cout<<front()<<endl;
							else
								break;
	}
	return 0;
}