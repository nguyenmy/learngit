#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#define MAX 100
typedef struct
{
	char mssv[8];
	char ten[30];
	float tk, gk, ck, th, dtb;
}SINHVIEN;
void nhapsv(SINHVIEN &sv);
void xuatsv(SINHVIEN sv);
void nhapds(SINHVIEN a[], int &n);
void xuatds(SINHVIEN a[], int n);
void timkiem(SINHVIEN a[], int n, char mssv[]);
void sapxep(SINHVIEN a[], int n);
void main()
{
	int n;
	char masv[8];
	SINHVIEN a[MAX];
    //SINHVIEN sv;
	/*nhapsv(sv);
	xuatsv(sv);*/
	nhapds(a, n);
	xuatds(a, n);
	printf_s("\nnhap ma sv can tim:");
	fflush(stdin);
	gets_s(masv, 8);
	timkiem(a, n, masv);
	sapxep(a, n);
	xuatds(a, n);
	_getch();
}
void nhapsv(SINHVIEN &sv)
{
	float tk, gk, ck, th;

	printf_s("\nnhap ho ten: ");
	fflush(stdin);
	//getchar();
	gets_s(sv.ten, 30);
	//sv.mssv[strlen(sv.mssv) - 1] = '\0';

	printf_s("\nnhap ma so sv: ");
	//getchar();
	fflush(stdin);
	gets_s(sv.mssv, 8);
	//sv.mssv[strlen(sv.mssv) - 1] = '\0';

	printf_s("nhap diem :");
	scanf_s("%f%f%f%f", &tk, &gk, &ck, &th);
	sv.tk = tk;
	sv.gk = gk;
	sv.ck = ck;
	sv.th = th;
	sv.dtb = ((2 * tk + 3 * gk + 5 * ck) / 10 * 2 + th) / 3;
}
void xuatsv(SINHVIEN sv)
{
	printf_s("\nho ten sv: %s", sv.ten);
	printf_s("\nmssv: %s", sv.mssv);
	printf_s("\nTK GK CK TH: %f%f%f%f", sv.tk, sv.gk, sv.ck, sv.th);
}
void nhapds(SINHVIEN a[], int &n)
{
	printf_s("\nnhap vao so sv: ");
	scanf_s("%d", &n);
	for (int i = 0; i < n; i++)
		nhapsv(a[i]);
}
void xuatds(SINHVIEN a[], int n)
{
	int dem = 0;
	printf_s("\n_____________________________________________");
	printf_s("\n|%-5s|%-30s|%-9s|%10s|", "STT", "HO VA TEN", "MSSV", "DTB");
	printf_s("\n_____________________________________________");
	for (int i = 0; i < n; i++)
	{
	printf_s("\n|%-5s|%-30s|%-9s|%10.2f|", dem, a[i].ten, a[i].mssv, a[i].dtb);
	printf_s("\n_____________________________________________");

	}
}


void timkiem(SINHVIEN a[], int n, char mssv[8])
{
	int flag = 0;
	for (int i = 0; i < n; i++)
	{
		if (strcmp(a[i].mssv, mssv) == 0)//so sanh
		{
			flag = 1;
			printf_s("\nho ten: %18s", a[i].ten);
			printf_s("\nma sinh vien: %s", a[i].mssv);
			printf_s("\ndiem thuong ky: %.2f", a[i].tk);
			printf_s("\ndiem giua ky: %.2f", a[i].gk);
			printf_s("\ndiem cuoi ky: %.2f", a[i].ck);
			printf_s("\ndiem trung binh: %.2f", a[i].dtb);
		}
	}
	if (flag == 0)
		printf_s("\nkhong tim thay");
}
void sapxep(SINHVIEN a[], int n)
{
	for (int i = 0; i < n; i++)
	for (int j = i + 1; j < n; j++)
	if (a[i].dtb >a[j].dtb)
	{
		SINHVIEN temp;
		temp = a[i];
		a[i] = a[j];
		a[j] = temp;
	}
}