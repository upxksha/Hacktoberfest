#include <stdio.h>

void main()
{

    //Question 01
    int i, sum = 0, avg, max, min;
    int num_array[5];

    for (i = 0; i < 5; i++)
    {
        printf("Enter the number : ");
        scanf("%d", &num_array[i]);
    }

    max = num_array[0];
    min = num_array[0];
    for (i = 0; i < 5; i++)
    {
        sum = sum + num_array[i];

        if (num_array[i] <= min)
        {
            min = num_array[i];
        }
        if (num_array[i] >= max)
        {
            max = num_array[i];
        }

        avg = sum / 5;
    }

    printf("The minimum  is %d\n", min);
    printf("The maximum  is %d\n", max);
    printf(" The sum is %d\n", sum);
    printf("The average is %d\n", avg);

for(i=5;i>=0;i--)
    {
        printf("%d",num_array[i]);
    }

    //Question 02
    int sum,i,size,summ;
    int arr01[size];
    int arr02[size];
    int arr03[size];

    printf(" Enter the size :");
    scanf("%d",&size);

    //scaler sum
    for(i=0;i<size;i++)
    {
        printf(" Enter the elements of array-01 : ",i+1);
        scanf("%d",&arr01[i]);
        sum=sum+arr01[i];
    }


    for(i=0;i<size;i++)
    {
        printf(" Enter the elements of array-02 : ",i+1);
        scanf("%d",&arr02[i]);
        sum=sum+arr02[i];
    }
     printf(" The 1st scaler sum is %d\n",sum);
    printf(" The 2nd scaler sum is %d\n",sum);

    //vector sum
     for(i=0;i<size;i++)
     {
         arr03[i]=arr01[i]+arr02[i];
         printf("%d\n",arr03[i]);
     }
     printf("\n\n");
    //vector product
    for(i=0;i<size;i++)
    {
        arr03[i]=arr01[i]*arr02[i];
        printf("%d\n",arr03[i]);
    }
    printf("\n\n");

    //scaler product
    for(i=0;i<size;i++)
    {
      summ=summ+arr03[i];
    }
    printf("Scaler product is %d\n",summ);


}

int main(){
    //Question 01
    int arr[3][5]={50,49,45,33,20,60,52,38,34,36,80,86,44,78,60};
int x,y;
for(x=0;x<3;x++)
{
for(y=0;y<5;y++)
{
printf("%d ",arr[x][y]);
}
printf("\n");
}

//Question 02
 int x[3][3]={3,2,4,1,4,6,4,3,2};
    int y[3][3]={2,6,3,4,3,2,5,1,7};
    int z[3][3];
    int i,j;

    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            z[i][j]=x[i][j]+y[i][j];
        }
    }
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            printf("%d",z[i][j]);
        }
        printf("\n");
    }

    //Question 03
    int x[3][3];
    int y[3][3];
    int i,j;
    int isequal=1;

    //Input 1st array
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            printf("Enter the number : ");
            scanf("%d",&x[3][3]);
        }
        printf("\n");
    }

    //Input 2nd array
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            printf("Enter the number : ");
            scanf("%d",&y[3][3]);
        }
        printf("\n");
    }
    //Display the array
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            printf("%d",x[i][j]);

        }
        printf("\n");
    }
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            printf("%d",y[i][j]);

        }
        printf("\n");
    }

    //Output

    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            if(x[i][j]!=y[i][j])
            {
                isequal=0;
                printf(" Two arrays are not equal\n ");
                break;
            }


        }
        if(isequal==0)
        {
            break;
        }
        if(isequal==1)
        {
            printf(" Two arrays are equal\n");
            break;
        }

        }
        printf("\n");
}

