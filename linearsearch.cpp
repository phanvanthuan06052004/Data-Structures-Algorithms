#include<bits/stdc++.h>
using namespace std;
bool linearsearch (int a[], int n, int x){
	int i=0;
	while(a[i]!=x &&i<n){
		i++;
	}
	return (i==n);
}

int main(){
	int a[100],n,x;
	cin>>n>>x;
	for(int i=0; i<n; i++)
		cin>>a[i];
	bool kq=linearsearch(a,n,x);
	if(kq==false)
		cout<<"co x";
	else
		cout<<"khong co x";
	return 0;
}