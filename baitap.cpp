#include<bits/stdc++.h>
using namespace std;

struct sinhvien{
	string ten;
	float diem;
};

struct SV{
	sinhvien s;
	SV* next;
	
	SV(sinhvien student) : s(student), next(nullptr) {}	
};

SV* makenode(sinhvien x){
	SV* tmp = new SV(x);
	tmp->s = x;
	tmp->next = nullptr;
	return tmp;
	 
}

void in1SV(sinhvien &s){
	cout<<"Ten: "<<s.ten<<", Diem: "<<s.diem<<endl;
}

void inNhieuSV(SV* head){
	SV* tmp=head;
	while(tmp!=NULL){
		in1SV(tmp->s);
		tmp=tmp->next;
	}
}
SV* xoasinhvienduoi5(SV* head){
	//ktr phan tu dau dsach
	while( (head != nullptr) && (head->s.diem<5)){
		SV* tam = head;
		head = head->next;
		delete tam;
	}
	//ktr cac ptu con lai
	SV* cn = head;
	while((cn!=nullptr) && (cn->next)){
		if(cn->next->s.diem<5){
			SV* tmp = cn->next;
			cn->next = cn->next->next;
			delete tmp;
		}
		else{
			cn = cn->next;
		}
	}
	return head;
}
SV* bubbleSort(SV* head) {
    if (head == nullptr) {
        return nullptr;
    }

    bool ktr;
    do {
        ktr = false;
        SV* p = nullptr;
        SV* tmp = head;

        while (tmp->next) {
            if (tmp->s.diem > tmp->next->s.diem) {
                if (p != nullptr) {
                    p->next = tmp->next;
                } else {
                    head = tmp->next;
                }

                SV* next = tmp->next->next;
                tmp->next->next = tmp;
                tmp->next = next;
                p = tmp;
                tmp = next;

                ktr = true;
            } else {
                p = tmp;
                tmp = tmp->next;
            }
        }
    } while (ktr);

    return head;
}

SV* findMaxAndInsertFirst(SV* head) {
    // Sắp xếp danh sách trước
    head = bubbleSort(head);

    // Sau khi sắp xếp, sinh viên có điểm cao nhất sẽ ở cuối danh sách
    // Đặt nó lên đầu danh sách
    SV* max = head;
    SV* current = head;

    while (current->next) {
        max = current;
        current = current->next;
    }

    max->next = nullptr;
    current->next = head;
    head = current;

    return head;
}
int main(){
	SV* head = nullptr;
	sinhvien x1,x2,x3;
	x1.ten="Phan Van Thuan";
	x1.diem=6;
	x2.ten="Phan Van Anh Ngoc";
	x2.diem=4;
	x3.ten="Nguyen Van Teo";
	x3.diem=6.8;
	
	head = makenode(x1);
	head->next = makenode(x2);
	head->next->next = makenode(x3);
	
	head = xoasinhvienduoi5(head);
	inNhieuSV(head);
	cout<<"----------------"<<endl;
	
	head = findMaxAndInsertFirst(head);
	inNhieuSV(head);
	
	
	SV* tmp = head;
	while(tmp!=NULL){
		SV* next = tmp->next;
		delete tmp;
		tmp = next;
	}
	return 0;
	
}