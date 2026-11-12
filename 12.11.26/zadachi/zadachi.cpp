#include <math.h> 
#include <iostream> // библиотека cout() и cin()
#include <stdio.h>
#include <clocale> // 

using namespace std;
int main()
{
	int a; int b;
	
	cout << "a =";cin >> a;
	
	cout << "b =";cin >> b;
	double y = sqrt(((2 * a) - b) / (a + b)) - sqrt(pow(a, 2) - pow(b, 2));
	
	printf("y = %.2lf", y);
}
