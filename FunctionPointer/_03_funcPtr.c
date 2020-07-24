#include <stdio.h>
#include <conio.h>
#include <Windows.h>

#define FUNC_NUM	10

enum {
	QUIT,
	LEFTDOWN, DOWN, RIGHTDOWN,
	LEFT, CENTER, RIGHT,
	LEFTUP, UP, RIGHTUP
};
int quit() {	printf("���α׷� ����\n");	return 0;}
int leftdown() {	printf("���ϴ�\n");	return 1;}
int down() { printf("�ϴ�\n"); return 1; }
int rightdown() { printf("���ϴ�\n"); return 1; }
int left() { printf("�´�\n"); return 1; }
int center() { printf("�߾�\n"); return 1; }
int right() { printf("���\n"); return 1; }
int leftup() { printf("�»��\n"); return 1; }
int up() { printf("���\n"); return 1; }
int rightup() { printf("����\n"); return 1; }
int configuration() {
	for (int i = 0; i < 5; i++) {
		system("cls"); 
		Sleep(200);		
		printf("*********************************\n");
		printf("*********Conguraturation*********\n");
		printf("*********************************\n");
		Sleep(200);
	}
	system("cls"); 
	return 1;
}
void play(int (*handler[])()) {
	while (1) {
		char ch = _getch();
		ch -= '0';
		if (ch >= 0 && ch <= 9) {
			if (handler[ch]() == 0)
				break;
		}
	}
}
void main() {
	int (*handler[FUNC_NUM])();

	handler[QUIT] = configuration;
	handler[LEFTDOWN] = leftdown;
	handler[DOWN] = down;
	handler[RIGHTDOWN] = rightdown;
	handler[LEFT] = left;
	handler[CENTER] = center;
	handler[RIGHT] = right;
	handler[LEFTUP] = leftup;
	handler[UP] = up;
	handler[RIGHTUP] = rightup;

	play(handler);
}