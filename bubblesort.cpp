#include<bits/stdc++.h>
using namespace std;

void hoandoi(int &a, int &b){
	int x=a;
	a=b;
	b=x;
}
void bubbleSort (int A[], int n){
	for(int i=0; i<n; i++){
		for(int j=n-1; j>i; j--){
			if(A[j]<A[j-1]){
				hoandoi(A[j],A[j-1]);
			}
		}
	}
}
//void bubbleSort(int A[], int n){
//	bool ktr;
//	for(int i=0; i<n; i++){
//		
//		ktr=false;
//		for(int j=0; j<n-i-1; j++){
//			if(A[j]>A[j+1]){
//				hoandoi(A[j],A[j+1]);
//				ktr=true;
//			}	
//		}
//	if(ktr==false)
//		break;
//	}
//}
int main(){
	int A[100],n;
	cin>>n;
	for(int i=0; i<n; i++){
		cin>>A[i];
	}
	bubbleSort(A,n);
	for(int i=0; i<n; i++)
		cout<<A[i]<<" ";
	return 0;
}

//	0 1 2 3 4 
//	2 5 1 7 9
//i=0:2 1 5 7 9 
//i=1:1 2 5 7 9
//i=2:
//	1 2 5 7 9
//	
//	
//	0 1 2 3 4 
//	7 1 2 9 5
//i=0:1 7 2 9 5
//i=1:1 2 7 9 5
//i=2:1 2 7 5 9
  //   1 2 5 7 9 
	                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            