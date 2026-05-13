#include <stdio.h>
#include <string.h>

int main()
{
    int reg;
    char stringa[100];
    int conta=0;
        printf("set register: ");
        scanf("%d", &reg);
        printf("insert program: ");
        scanf("%s", stringa);
    for(int i=0; stringa[i]!='\0'; i++)
{
    if(conta>=1000)
{
        printf("failure: process killed");
    return 0;
}
    else
{
    if(stringa[i]=='I') {reg+=1; conta+=1;}
    if(stringa[i]=='D') {reg-=1; conta+=1;}
    if(stringa[i]=='P'){ printf("@> %d\n", reg); conta+=1;}
    if(stringa[i]=='J') {if(reg > 0) {i=-1; conta+=1;}  
    else conta+=1;
}
}
}
    if(conta<1000) printf("sucess: process completed");
}