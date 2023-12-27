#include<bits/stdc++.h>
using namespace std;

bool binarysearch(int A[], int n, int x){
	int l=0;
	int r=n-1;
	while(l<=r){
		int mid=(r+l)/2;
		if(A[mid]==x)
			return true;
		else
			if(x>A[mid])
				l=mid+1;
			else
				r=mid-1;
	}
	return false;
}
int main(){
	int A[100],n,x;
	cin>>n>>x;
	for(int i=0; i<n; i++)
		cin>>A[i];
	bool kq=binarysearch(A,n,x);
	if(kq==true)
		cout<<"co x";
	else
		cout<<"khong co x";
	return 0;
}