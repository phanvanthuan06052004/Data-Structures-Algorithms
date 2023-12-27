//thuat toan sort
#include<bits/stdc++.h>
using namespace std;

void Hoandoi(int &a, int &b){
	int x=a;
	a=b;
	b=x;
}

void sapxep(int A[], int n){
	for(int i=0; i<n-1; i++){
		int min=i;
		for(int j=i+1; j<n; j++){
			if(A[j]<A[min])
				min=j;
		}
		Hoandoi(A[min],A[i]);
	}
}

int main(){
	int A[100],n;
	cin>>n;
	for(int i=0; i<n; i++)
		cin>>A[i];
	sapxep(A,n);
	for(int i=0; i<n; i++){
		cout<<A[i]<<" ";
	}
	return 0;
}


//3 4 5 1 2 
//1 4 5 3 2
//1 2 5 3 4 
//1 2 3 5 4
//1 2 3 4 5 
