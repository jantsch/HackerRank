import java.io.*;
 import java.util.*;
 public class gp
 {
     public static void main(String args[])throws IOException
     {
       
         Scanner in=new Scanner(System.in);
         int i;
        int n,k;
        n=in.nextInt();k=in.nextInt();
        int a[]=new int[n];
        int b[]=new int[n];
        for(i=0;i<n;i++)
        {
            a[i]=in.nextInt();
            b[i]=in.nextInt();
         }
         int c[]=new int[n];
         int sum=0;int index=0;
         for(i=0;i<n;i++)
         {
             if(b[i]==0)
             {
                 sum=sum+a[i];
             }
             else
             {
                 c[index]=a[i];
                 index++;
             }
         }
         Arrays.sort(c);
         i=n-1;
         while(i>=0 && k>0)
         {
             sum=sum+c[i];
             k--;i--;
     }int cout=0;
     while(i>=0)
     {
         cout=cout+c[i];
         i--;}
         System.out.println(sum-cout);
     }
 }