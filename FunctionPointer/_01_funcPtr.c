#include <stdio.h>

void korPresentaion()
{
	printf("������ �Է��ϼ��� >> ");
}

void engPresentation()
{
	printf("Input Integer >> ");
}

int inputValue(void (*present)())
{
	present();
	int num = 0;
	scanf_s("%d", &num);
	return num;
}

void main()
{
	int value = 0;
	value = inputValue(engPresentation);
	printf("%d\n", value);

}