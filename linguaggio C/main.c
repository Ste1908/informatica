
#include <stdio.h>

int main()
{
char stringa[100];
int chiave;
printf("inserisci la stringa: ");
scanf("%s", stringa);
printf("inserisci la chiave: ");
scanf("%d", &chiave);
for(int i=0; stringa[i]!='\0'; i++){
    if(stringa[i]+chiave>90){
        stringa[i]=(chiave-(90-stringa[i]))+64;
    }else
{
    stringa[i]+=chiave;
}
   printf("%c", stringa[i]);
}
}
