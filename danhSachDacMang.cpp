#include<bits/stdc++.h>
#define max 100
using namespace std;
struct alist{
	int A[max];
	int n;
};

void initialist (alist &l){
	l.n=0;
}
void insertlastlist(alist &l, int x){
	l.A[l.n]=x;
	l.n++;
}

void insertList(alist &l, int x, int pos){
	if(pos>=0 && pos<=l.n){
		for(int i=l.n; i>pos; i--){
			l.A[i]=l.A[i-1];
		}
		l.A[pos]=x;
		l.n++;
	}
}
void sort(alist &l){
	for(int i=0; i<l.n-1; i++){
		int min=i;
		for(int j=i+1; j<l.n; j++){
			if(l.A[j]<l.A[min])
				min=l.A[j];
		}
		int tmp=l.A[min];
		l.A[min]=l.A[i];
		l.A[i]=tmp;
	}	
}
void remove(alist &l, int k){
	if(k>=0 && k<=l.n){
		for(int i=k; i<l.n; i++){
			l.A[i]=l.A[i+1];
		}
		l.n--;
	}
}
void duyet(alist l){
	for(int i=0; i<l.n; i++){
		cout<<l.A[i]<<" ";
	}
}
int main(){
	alist l;
	initialist(l);
	int x,pos,k;
	while(1){
		cout<<"------------------------------------\n";
		cout<<"1.insertlastlist\n";
		cout<<"2.insertList\n";
		cout<<"3.remove\n";
		cout<<"4.duyet\n";
		cout<<"0.exit\n";
		cout<<"5. sort\n";
		cout<<"------------------------------------\n";
		int lc; cin>>lc;
		if(lc==1){
			cout<<"Nhap x: ";
			cin>>x;
			insertlastlist(l,x);
		}
		else
			if(lc==2){
				cout<<"nhap x: "; cin>>x;
				cout<<"nhap pos: "; cin>>pos;
				insertList(l,x,pos);
			}
			else
				if(lc==3){
					cout<<"Nhap k: ";cin>>k;
					remove(l,k);
				}
				else
					if(lc==4){
						duyet(l);
					}
					else
						if(lc==5){
							sort(l);
						}
					else
						break;
	}
	return 0;
}