#include<bits/stdc++.h>
using namespace std;

int n=0;
int st[10000];
void push(int x){
	st[n]=x;
	n++;
}
int top(){
	return st[n-1];
}
void pop(){
	if(n==0)
		return;
	n--;
}
int size(){
	return n;
}
int main(){
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
			push(x);
		}
		else
			if(lc==2)
				pop();
			else
				if(lc==3)
					cout<<top()<<endl;
				else
					if(lc==4){
						cout<<size();
					}
					else
						break;					
	}
	return 0;
}