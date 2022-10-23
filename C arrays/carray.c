#include <stdio.h>
#include <stdlib.h>

int main()
{

    int array_1[3][3];
    int array_2[3][3];
    int array_3[3][3];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("Enter a value to array 1: ");
            scanf("%d", &array_1[i][j]);
        }
    }

    printf("\n");
    printf("\n");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("Enter a value to array 2: ");
            scanf("%d", &array_2[i][j]);
        }
    }

    printf("\nValues in the array 1\n");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%d ", array_1[i][j]);
        }
        printf("\n");
    }

    printf("\nValues in the array 2\n");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%d ", array_2[i][j]);
        }
        printf("\n");
    }

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            array_3[i][j] = array_1[i][j] + array_2[i][j];
        }
    }

    printf("\nValues in the array 3\n");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%d ", array_3[i][j]);
        }
        printf("\n");
    }



    return 0;
}N
