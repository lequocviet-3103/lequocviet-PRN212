int sum(params int[] arr) //truyền bao nhiêu đối số cũng đc
{
    int s = 0;
    foreach (int x in arr)
    {
        s += x;
       
    }
     return s;
}

int s0 = sum();
int s1 = sum(100);
int s2 = sum(100, 200);
int sn = sum(4,5,6,7,8,9,545,45);

