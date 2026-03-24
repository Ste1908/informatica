#include <stdio.h>
#include <string.h>
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
if(b==0) printf("non è presente un'antenata comune");
else {printf("antenata comune: %s\n", antenato);
 printf("%d di %s\n", strlen(nome_1)-b, nome_1);
       printf("%d di %s", strlen(nome_2)-b, nome_2);
}
}



#include <stdio.h>
#include <string.h>
int main()
{
char nome_1[1000];
char nome_2[1000];
int controllore=0;
int b=0;
printf("inserisci nome 1: ");
scanf("%s", nome_1);
printf("inserisci nome 2: ");
scanf("%s", nome_2);
for(int i = 0; nome_1[i]!='\0'&& nome_2[i]!='\0';i++){
    if(strlen(nome_1)>strlen(nome_2)) {
         if(nome_1[i]==nome_2[b]) b+=1;
         else controllore+=1;
    }
    else if(nome_1[b]==nome_2[i]) b+=1;
    else controllore+=1;
}
if(controllore==1) {
    if(strlen(nome_1)>strlen(nome_2)) printf (" %s madre di %s", nome_2, nome_1);
    else printf (" %s madre di %s", nome_1, nome_2);
} else printf("nessuna relazione madre figlia tra %s e %s", nome_1, nome_2);
}
