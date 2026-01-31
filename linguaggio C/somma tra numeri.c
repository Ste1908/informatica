/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
int main ()
{
    int x;
    int y;
    int somma;
    printf("inserire il primo valore");
    scanf("%d", &x);
    printf("inserire secondo valore");
    scanf("%d", &y);
    somma=x+y;
    printf("la somma è: %d", somma);
}