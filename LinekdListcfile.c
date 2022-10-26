#include <stdio.h>
#include <stdlib.h>

//skelton for every node of linked list

struct Node
{
	int data;
	struct Node *next;	
};

//function to print all the elements in linked list

void display(struct Node *n)
{
	while(n != NULL)
	{
		printf("%d\t",n->data);
		n = n->next;
	}
}

void findMiddle(struct Node *head)
{
	struct Node *slow = head;
	struct Node *fast = head;
	
	if(head != NULL)
	{
		while(fast!=NULL && fast->next!=NULL)
		{
			fast = fast->next->next;
			slow = slow->next;
		}
	}
	printf("Middle element is : %d",slow->data);
}

int main()
{
	struct Node *nd[10] = {NULL};
	
	//memory allocation
	for(int i=0; i<10; i++)
	{
		nd[i] = (struct Node*)malloc(sizeof(struct Node));
	}

	//assignning values to Nodes
	for(int i=0; i<10; i++)
	{
		printf("Insert number %d:  ",i+1);
		scanf("%d",&(nd[i]->data));
	}
	
	//linking Nodes
	for(int i=0; i<9; i++)
	{
		nd[i]->next = nd[i+1];
	}
	nd[9]->next = NULL;
	
	//calling display
	display(nd[0]);
	printf("\n");
	
	findMiddle(nd[0]);
	printf("\n");
	
	return 0;
}
