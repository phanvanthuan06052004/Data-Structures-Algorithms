//thuat toan quick sort
#include<bits/stdc++.h>
using namespace std;

void hoanvi(int &a, int &b){
	int x=a;
	a=b;
	b=x;
}

void quicksort(int A[], int l, int r ){
	int i=l,j=r;
	int x=A[(i+j)/2];
	do{
		while(A[i]<x) i++;
		while(A[j]>x) j--;
		if(j>=i){
			hoanvi(A[i],A[j]);
			i++;
			j--;
		}
	} while(j>i);
	if (l < j) quicksort(A, l, j);  
    if (i < r) quicksort(A, i, r);
}

int main(){
	int A[100],n;
	cin>>n;
	int l=0, r=n-1;
	for(int i=0; i<n; i++)
		cin>>A[i];
	quicksort(A,l,r);
	for(int i=0; i<n; i++){
		cout<<A[i]<<" ";
	}
	return 0;
}
