#include <stdio.h>
// Question 01
int stack[5];
int top=-1;

void push(int data)
{
    top=top+1;
    stack[top]=data;
}

void printdata()
{
    int i;
    for(i=top;i>=0;i--)
    {
       printf("%d\n",stack[i]);
    }
}

int main()
{
    int times,number,i;

    printf("How many elements to be pushed in to the stack");
    scanf("%d",&times);

    for(i=0;i<times;i++)
    {
        printf("Enter the %d index value to be pushed in to the stack",i);
        scanf("%d",&number);
        push(number);
    }

    printf("the status of the status is \n");
    printdata();


    return 0;


}

//Question 02
int main()
{
    int  item_num[10] = {1,2,3,4,5,6,7,8,9,10};
    float pro_price[10] ={1000,2000,3000,4000,5000,6000,7000,8000,9000,10000};
     int mid,first=0,last=9,key;

    printf("Enter the item number to search: ");
    scanf("%d",&key);

    while(first<=last)
    {
        mid = (first+last)/2;
        if(key==item_num[mid])
        {

            printf("The product price for %d item number is %f",key,pro_price[mid]);

            break;}

        if(key < item_num[mid])
           last = mid-1;

        if(key > item_num[mid])
           first = mid+1;

    }

}

//Question 03
int main()
{
    int x=15,y=16,z=6,s=8,d=12,l=5,temp;

    temp=x;
    x=l;
    l=z;
    z=s;
    s=d;
    d=x;
    x=y;
    y=temp;

    printf("%d\n",x);
    printf("%d\n",y);
    printf("%d\n",z);
    printf("%d\n",s);
    printf("%d\n",d);
    printf("%d\n",l);
}

//Lab session 01
int stack[10];
int top=-1;

//Input and print stack
void push(int data)
{
    top=top+1;
    stack[top]=data;
}

void printdata()
{
    int i;
    for(i=top;i>=0;i--)
    {
        printf("%d\n",stack[i]);
    }
}
int main()
{
    push(56);
    push(67);

    printdata();

    return 0;
}


    int queue[5];
    int front=0;
    int rear =-1;
    int max=5;


void enqueue(int data)
{
    rear=rear+1;
    queue[rear]=data;
}

void dequeue()
{
    printf("Value extract is %d\n",queue[front]);
    front=front+1;

}

void isfull()
{
    if(rear==max-1)
    {
        printf("Queue is full!!\n");
    }
    else
    {
        printf("Queue is not full !!\n");
    }
}
void print()
{
    int i;
    printf("The queue \n");
    for(i=front;i<=rear;i++)
    {
        printf("%d\n",queue[i]);
    }
}

int main()
{
    enqueue(25);
    enqueue(34);
    enqueue(67);
    print();

    dequeue();
    dequeue();
   print();

    return 0;
}

//Question 05
int main()
{
    int data[10]={21,29,32,37,41,49,55,60,75,98};

    int key,mid,first=0,last=9;

    printf("Enter key to search?\n");
    scanf("%d",&key);

    while(first<=last)
    {
        mid=(first+last)/2;
        if(key==data[mid]){
                printf("Data found at %d\n",mid);
                break;}
        if(key<data[mid])
            last=mid-1;
        if(key>data[mid])
            first=mid+1;



    }
}
