//sahansa
#include <stdio.h>
int main() {

//initializing variables
int a,b,operation;

//Getting User Inuts
print("Enter number 01");
scanf("%d",&a);

printf("Enter number 02");
scanf("%d",&b);

  printf("\nInput the operation\n");
    printf("\n1 :: for Addition");
    printf("\n2 :: for Substraction");
    printf("\n3 :: for Multiplication");
    printf("\n4 :: for Division");
    printf("\n5 :: for Modulus");

    printf("\n\nEnter your choice: ");
    scanf("%d", &operation);

    printf("\n");
    //conditioning
    if (operation == 1) {
        printf("Addition of %d + %d = %d\n", a, b, a + b);
    } else if (operation == 2) {
        printf("Substraction of %d - %d = %d\n", a, b, a - b);
    } else if (operation == 3) {
        printf("operatrion of %d * %d = %d\n", a, b, a * b);
    } else if (operation == 4) {
        printf("Division of %d / %d = %f\n", a, b, (float)a / b);
    } else if (operation == 5) {
        printf("Modulus of %d %% %d = %d\n", a, b, a % b);
    } else {
        printf("\nKindly input correct choice!\n");
    }
    return 0;
}
