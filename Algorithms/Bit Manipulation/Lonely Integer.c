#include <stdio.h> 
#include <string.h> 
 #include <math.h> 
 #include <stdlib.h> 
 #include <assert.h> 
 /* Head ends here */ 
 int lonelyinteger(int a_size, int* a) { 
 
 
     int i,j,n=a_size,temp,flag; 
    for(i=0 ; i<n ; i++) 
  { 
   for(j=0 ; j<n-i-1 ; j++) 
   { 
    if(a[j]>a[j+1]) //Swapping Condition is <span class="IL_AD" id="IL_AD9">Checked</span> 
    { 
     temp=a[j]; 
     a[j]=a[j+1]; 
     a[j+1]=temp; 
    } 
   } 
  } 
  i=0; 
 while(i!=n){ 
 if(a[i]!=a[i+1]) 
 { 
     return a[i]; 
 
 
 } 
 i=i+2; 
 } 
 
 
 return a[n]; 
 } 
 /* Tail starts here */ 
int main() { 
     int res; 
 
 
     int _a_size, _a_i; 
     scanf("%d", &_a_size); 
     int _a[_a_size]; 
     for(_a_i = 0; _a_i < _a_size; _a_i++) { 
         int _a_item; 
         scanf("%d", &_a_item); 
 
 
         _a[_a_i] = _a_item; 
     } 
 
 
     res = lonelyinteger(_a_size, _a); 
     printf("%d", res); 
 
 
     return 0; 
 } 
