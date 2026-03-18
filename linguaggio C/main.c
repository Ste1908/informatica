#include <stdio.h>
int main()
{
char nome_1[1000];
char nome_2[1000];
char antenato[1000];
int b=0;
printf("inserisci nome 1: ");
scanf("%s", nome_1);
printf("inserisci nome 2: ");
scanf("%s", nome_2);
    for(int i=0; nome_1[i]!='\0'&&nome_2[i]!='\0'; i++){
    if(nome_1[i]==nome_2[i]&&b==i) {
        antenato[b]=nome_2[i];
        b+=1;
    }
}
printf("antenata comune: %s", antenato);
}