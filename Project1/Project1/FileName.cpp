#include <iostream>
using namespace std;
int main() {
	setlocale(LC_ALL, "ru");
	int firstNumber{}, secondNumber{};
	cout << "Введите первое число";
	cin >> firstNumber;
	cout << "Введите второе число";
	cin >> secondNumber;
	cout << "Сумма = " << firstNumber + secondNumber;
	cout << "\nРазность = " << firstNumber - secondNumber;
	cout << " \nПроизведение = " << firstNumber + secondNumber;
	cout << "\nСр. арифм. = " << (firstNumber + secondNumber) / 2;

	int tc ;
	cin >> tc;
	cout << "Температура в Фаренгейтах: " << tc * 9 / 5 + 32;


}