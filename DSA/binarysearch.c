#include <stdio.h>
#include <stdlib.h>

int main()
{

    int data[10] = {21, 29, 32, 37, 41, 49, 55, 60, 75, 98};

    int key;
    printf("Enter key to Search: ");
    scanf("%d", &key);

    int mid;
    int first = 0;
    int last = 9;

    while (first <= last)
    {
        mid = (first + last) / 2;

        if (key == data[mid])
        {
            printf("Data found at %d\n", mid);
            break;
        }

        // Bring the last to the (mid - 1) value
        if (key < data[mid])
        {
            last = mid - 1;
        }

        // Bring the first to the (mid + 1) value
        if (key > data[mid])
        {
            first = mid + 1;
        }
    }

    retrun 0 ;

}
