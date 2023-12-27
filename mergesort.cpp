#include<bits/stdc++.h>
using namespace std;

void merge(int A[], int mid, int l, int r){
	int n1=mid - l+1;
	int n2=r-mid;
	
	int left[n1];
	int right[n2];
	
	for(int i=0; i<n1; i++){
		left[i]=A[l+i];
	}
	for(int j=0; j<n2; j++){
		right[j]=A[mid + 1 + j];
	}
	int i=0; 
	int j=0; 
	int k=l;
	
	while(i<n1 && j<n2){
		if(left[i]<= right[j]){
			A[k]=left[i];
			i++;
		}
		else{
			A[k]=right[j];
			j++;
		}
		k++;	
	}
	
	while(i<n1){
		A[k]=left[i];
		i++;
		k++;
	}
	while(j<n2){
		A[k]=right[j];
		j++;
		k++;
	}
	
}

void mergesort(int A[], int l, int r){
	int mid;
	if(r>l){
		mid=(l+r)/2;
		mergesort(A,l,mid);
		mergesort(A,mid+1,r);
	
	merge(A,mid,l,r);
	}

}

int main(){
	int A[100],n;
	cin>>n;
	int l=0,r=n-1;
	for(int i=0; i<n; i++){
		cin>>A[i];
	}
	mergesort(A,l,r);
	for(int i=0; i<n; i++)
		cout<<A[i]<<" ";
	return 0;
}
