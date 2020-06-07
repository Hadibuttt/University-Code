#include<iostream>
using namespace std;
int main ()
{
    int scores[5][5], i, j, k, l;
    for(i=1;i<=5;i++)
    {
            cout<<"Enter scores for the student "<<i<<endl;
        for(j=1;j<=5;j++)
        {
            cin>>scores[i][j];
        }
    } 
    cout<<"Enter row number:";
    cin>>k;
    cout<<"Enter student number in that row:";
    cin>>l;
    if(k<=5&&l<=5)
    cout<<"Score is "<<scores[k][l];
    else 
    cout<<"Invalid input.";
}
