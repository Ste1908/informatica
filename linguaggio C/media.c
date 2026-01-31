/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>

int main()
{
    int a;
    int x;
    int raggio;
    int y;
    int z;
    int c;
    int e;
    printf("inserire il valore D: ");
    scanf("%d", &a);
    x=a*a;
    printf(" l'area del quadrato è: %d", x);
    raggio=a/2;
    y=raggio*raggio*3.14;
    printf("/l'area del cerchio è: %d", y);
    c=a*a;
    e=1.73205080757;
    z=c*e/4;
    printf("/l'area del triangolo è: %d", z);
}
