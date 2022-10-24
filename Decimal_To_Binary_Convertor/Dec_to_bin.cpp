#include <iostream>
using namespace std;

void convertor(int num)
{
    int arr[100];
    int i = 100;
    while(num)
    {
        i--;
        arr[i] = num %2;
        num /= 2;
    }

    for(int j = i;j<100;j++)
    {
        cout<<arr[j];
    }
}

int main()
{
    int dec_num;
    cout<<"Enter the Decimal number here ";
    cin>>dec_num;

    cout<<"Equivalent Binary number of given Decimal number "<<dec_num<<" is ";
    convertor(dec_num);
    return 0;
}
