#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>
float gittata_max(float veloctità){
    float gittata_max;
    float G=9.81;
    gittata_max=(pow(veloctità, 2))/G;
    return gittata_max;
}

int main()
{
    int u;
    printf("premere 0 per la simulazione del moto parabolico/ 1 per giocare ");
    scanf("%d",&u);
    if(u==0){
   
    float a;
    float v;
    float t;
    float pos_x;
    float pos_y;
    float tempo;
    float h;
    float l;
    float y_0=0;
    int p;
    float g=9.81;
    float pg=3.14;
    printf("\n=== SIMULATORE MOTO PARABOLICO ===\n");
printf("\ninserisci l'angolo di lancio (in gradi) : ");
scanf("%f",&a);
printf("inserisci la velocità iniziale (m/s) : ");
scanf("%f",&v);
printf("inserisci il delta_t per la simulazione (s) : ");
scanf("%f",&t);
printf("inserisci l'altezza di partenza (m) : ");
scanf("%f",&y_0);
printf("inserisci il tipo di lancio: 1-verso l'alto o verso il basso/ 2-orizzontale : ");
scanf("%d",&p);
a=a*(pg/180);
tempo=(2*v*/*sb*/sin(a))/g;
h=pow(v*sin(a), 2)/(2*g);
printf("\n=== DATI CALCOLATI ===\n");
printf("Tempo di volo: %.3f s \nGittata max: %.3f m\nAltezza max: %.3f m\n", tempo,gittata_max(v),h);
l=t;
printf("\n=== TRAIETTORIA ===\n");
printf("t (s)     pos_x (m)     pos_y (m)\n");
printf("---------------------------------\n");
printf("0.000     0.000         %.3f\n",y_0);
while(t<tempo){
pos_x=(v*cos(a))*t;
if(p==1){pos_y=(v*sin(a))*t-0.5*g*pow(t,2)+y_0;}
else {pos_y=y_0-0.5*g*pow(t,2);}
printf("%.3f     %.3f         %.3f\n", t, pos_x, pos_y);
t=t+l;
}
}
if(u==1)
{
    float dimensione_bersaglio;//dimensione del bersaglio
    //float a;
    float v;//velocità
    int conta=1;
    int k;//distanza massima del bersaglio
    float vento;//velocità del vento
    int munizioni;//massimo numero di munizioni
    
    printf("======= THE GAME =======\n");
    printf("inserisci la distanza massima a cui si può trovare il bersaglio: ");
    scanf("%d",&k);
     printf("inserisci la dimensione del bersaglio: ");
    scanf("%f",&dimensione_bersaglio);
    printf("inserisci la velocità del vento: ");
    scanf("%f",&vento);
    printf("inserisci un massimo di colpi: ");
    scanf("%d",&munizioni);
    printf("inserisci 0 nella velocità per uscire dal gioco\n");
    printf("=====================\n");
    srand(time(NULL));
   float numero_casuale=(rand()% k) + 1;
/*printf("\ninserisci l'angolo di lancio (in gradi) : ");
scanf("%f",&a);*/
printf("inserisci la velocità iniziale (m/s) : ");
scanf("%f",&v);
//a=a*(3.14/180);
do{
    if((gittata_max(v)-numero_casuale)>dimensione_bersaglio&&(gittata_max(v)-numero_casuale)<-dimensione_bersaglio){
    if(vento==0&&v!=0){
    if(gittata_max(v)<numero_casuale){printf("la freccia è atterrata qua: %.2f; è troppo corto, riprova\n",gittata_max(v));
    printf("=====================\n");
       /* printf("\ninserisci l'angolo di lancio (in gradi) : ");
scanf("%f",&a);*/
printf("inserisci la velocità iniziale (m/s) : ");
scanf("%f",&v);
//a=a*(3.14/180);
conta=conta+1;
    }
    else{
        printf("la freccia è atterrata qua: %.2f; é troppo lungo, riprova\n",gittata_max(v));
        printf("=====================");
        /*printf("\ninserisci l'angolo di lancio (in gradi) : ");
scanf("%f",&a);*/
printf("inserisci la velocità iniziale (m/s) : ");
scanf("%f",&v);
//a=a*/*sb*/(3.14/180);
conta=conta+1;
    }}
    if(vento>0||vento<0&&v!=0){
        //formule fisiche in presenza di vento
    }
    if(gittata_max(v)==0) conta=munizioni+1;
   if(gittata_max(v)==numero_casuale){
       conta=munizioni+1;
        printf("=====================\n");
        printf("Complimenti!! hai vinto in %d tentativi\nil bersaglio era in questa posizione: %.2f m",conta,numero_casuale);
}}else {
        printf("=====================\n");
        printf("Complimenti!! hai vinto in %d tentativi\nil bersaglio era in questa posizione: %.2f m\n",conta,numero_casuale); 
        conta=munizioni+1;
}
}while(conta<munizioni);
if((gittata_max(v)-numero_casuale)>dimensione_bersaglio&&(gittata_max(v)-numero_casuale)<-dimensione_bersaglio){
        printf("=====================\n");
        printf("GAME OVER\nil bersaglio era in questa posizione: %.2f m",numero_casuale);
}
}
}