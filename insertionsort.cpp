#include<bits/stdc++.h>
using namespace std;

void insertionsort(int A[], int n){
	for(int i=1; i<n; i++){
		int key=A[i];
		int j=i-1;
		while(j>=0 && A[j]>key){
			A[j+1]=A[j];
			j--;
		}
		A[j+1]=key;
	}
}

int main(){
	int A[100],n;
	cin>>n;
	for(int i=0; i<n; i++){
		cin>>A[i];
	}
	insertionsort(A,n);
	for(int i=0; i<n; i++)
		cout<<A[i]<<" ";
	return 0;
}
/*0  1  2  3 4 
12 11 13 5 6
i=1: 11	12	13	5 6
i=2: 11 12 13 5 6
i=3: 5 11 12 13 6
i=4: 5 6 11 12 13
5 6 11 12 13*/