#include "stdio.h"
#include "math.h"
void hexa(int);
void main(){
    int num;
    printf("Enter the Decimal number : ");
    scanf("%d",&num);
    hexa(num);
}

void hexa(int dec){
    if(dec<=0){
        return;
    }
    else{
        hexa(dec/16);
        if(dec%16<10){
            printf("%d",dec%16);
        }
        else{
            printf("%c",(dec%16)+55);
        }
    }
}