#include <stdio.h>
#include <math.h>
#define digits(n) (__typeof(n))(floor(1.0 * log10(1.0 * n))) + 1

int main() {
  long p, q, i, o, v, cnt = 0;
  scanf("%li %li", &p, &q);
  for(i = p; i <= q; ++i) {
    o = i*i;
    v = (long)pow(10, digits(i));
    if (o % v + o / v == i){
      printf("%li ", i);
      cnt++;
    }
  }
  if(!cnt) {
    printf("INVALID RANGE");
  }
  return 0;
}