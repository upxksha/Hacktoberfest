#include <stdio.h>
#include <stdlib.h>

int main()
{
    //declaring variables
    float number1;
    float number2;
    char sign;
    float output;
    int tmp1,tmp2;

    //getting first number
    printf("Enter First Number: ");
    scanf("%f",&number1);

    //getting second number
    printf("Enter second Number: ");
    scanf("%f",&number2);
    printf("\n");

    //printing action signs
    printf("Summation: + \n");
    printf("Subtraction: - \n");
    printf("Multiplication: * \n");
    printf("Division: / \n");
    printf("Modulo: %% \n\n");
    //getting arithmetic sign
    printf("Enter the arithmetic action sign: ");
    scanf(" %c",&sign);

    //action and output
    switch(sign)
    {

    case '+':

        output=number1+number2;
        printf("summation is %.3f \n",output);
        break;

    case '-':

        output=number1-number2;
        printf("Subtraction is %.3f \n",output);
        break;

    case '*':

        output=number1*number2;
        printf("Multiplication is %.3f \n",output);
        break;

    case '/':

        output=number1/number2;
        printf("Division is %.3f \n",output);
        break;

    case '%':

        tmp1 = (int)number1;
        tmp2 = (int)number2;

        output=tmp1%tmp2;
        printf("Modulo is %.0f \n",output);
        break;

    default:
        printf("Invalid Arithmetic Sign \n");
        break;

    }
    return 0;
}
