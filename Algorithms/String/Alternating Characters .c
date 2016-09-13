#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
    int t;
    char str[100001];

    scanf("%d", &t);
    for (int i = 0; i < t; i++) {
        int deletions = 0;
        char *follower = str;
        char *leader = str + 1;
        scanf("%s", str);
        while (*leader) {
            deletions += !(*follower++ ^ (*leader++));
        }
        printf("%d\n", deletions);        
    }
    return 0;
}