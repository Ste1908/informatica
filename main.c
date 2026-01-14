#include <stdio.h>
#include <string.h>
int main() {

    char stringa[100]; // dichiarazione di un array di 100 caratteri
    int lunghezza=0;
    printf("### GESTIONE BASE DELLE STRINGHE IN C ###\n\n");
   /*
   In C lo specificatore di formato %s permette di gestire stringhe 
   (array di char) con le funzioni printf e scanf. 
   Con printf stampa la stringa, con scanf legge una stringa,
   ma la lettura si interrompe al primo spazio individuato.
   */
    
    printf("\n# INPUT #\n");
    printf("Inserisci una stringa (senza spazi): ");
    scanf("%s",stringa); 
    
    printf("\n# OUTPUT #\n");
    
    printf("Stringa inserita: %s\n",stringa);
    int i=0;
    lunghezza=strlen(stringa);
    printf("la lunghezza è: %d\n", lunghezza);
    do{
        printf("%c\n",stringa[i]);
        i+=1;
    }while(stringa[i]!='\0');
    
    
    //printf("La stringa inizia con: %c\n",stringa[0]);
    
    /* Due questioni, per iniziare:
    1. Ma quindi si possono avere stringhe contenenti spazi?
    Certo, e lo vediamo subito con un esempio, e impareremo a gestirle!
    2. Ma se le stringe sono array di char, li posso scorrere con un ciclo?
    Certo, con qualche accortezza*/
     
    return 0;
}