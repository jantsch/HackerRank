
August 29, 2016 by anon	
  
/*
*  Code By : Pritish Thakkar
*  Contest :  World CodeSprint 6
*  Hint : Corners of a square matrix remain corners no matter
*         how many times you invert them (Tricky Hint) !
*  Solution : 
*           A1  A2  B2  B1
*           A3  A4  B4  B3
*           D3  D4  C4  C3
*           D1  D2  C2  C1
*           Ans = 0 -> initially 
*           Ans += maximum_of(A1, B1, C1, D1);
*           Ans += maximum_of(A2, B2, C2, D2);
*           Ans += maximum_of(A3, B3, C3, D3);
*           Ans += maximum_of(A4, B4, C4, D4);
*           print Ans
*           That's it !
*/
#include<bits/stdc++.h>

using namespace std;

typedef long long ll;

int main(){
	ll t;
	cin>>t;
	while(t--){
		ll n;
		cin>>n;
		ll an = 2*n;
		ll a[an][an];
		
		for(ll i=0;i<an;i++){
			for(ll j=0;j<an;j++) cin>>a[i][j];	
		}
		
		ll maxi=-1;
		ll sum = 0;
		for(ll i=0;i<n;i++){
			for(ll j=0;j<n;j++){
				ll adder = a[i][j];
				adder = max(adder,max(a[an-i-1][j],a[i][an-j-1]));
				adder =  max(adder,a[an-i-1][an-j-1]);
				sum += adder;
			}
		}
		cout<<sum<<endl;
	}
}
