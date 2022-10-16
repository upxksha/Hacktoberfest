
#include <stdio.h>

int main()
{
    int ar1[10], ars;
    printf("Enter Size of array");
    scanf("%d", &ars);
    for (int p = 0; p < ars; p++)
    {
        printf("Enter %d value ", ++p);
        scanf("%d", &ar1[p]);
    }

    int ln, sn, avg = 0, rvs, n;
    ln = ar1[0];
    sn = ar1[0];
    for (n = 0; n < 10; n++)
    {
        if (ln < ar1[n])
        {
            ln = ar1[n];
        }
        if (sn > ar1[n])
        {
            sn = ar1[n];
        }
        avg += ar1[n];
    }
    printf("Large number is %d \n", ln);
    printf("Small number is %d \n", sn);
    printf("Average %d \n", avg / 10);

    for (rvs = 9; rvs > -1; rvs--)
    {
        printf(" Reverse %d", ar1[rvs]);
    }

    return 0;
}