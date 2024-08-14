//*****************************************************************************
//* 719. Find K-th Smallest Pair Distance  leetcode                          **
//** Hash Table Solution, bery slow.                                 -Dan    **
//*****************************************************************************


int smallestDistancePair(int* nums, int numsSize, int k) {
    int small = 2147483647;
    int big = -1;
    int paircound = 0;
    int pairs[1062000] = {0};
    for(int i = 0; i < numsSize-1; i++)
    {
        for(int j = i + 1; j < numsSize; j++)
        {
            int absoluteDifference = abs(nums[i]-nums[j]);
            if(absoluteDifference < small) small = absoluteDifference;
            if(absoluteDifference > big) big = absoluteDifference;
            pairs[absoluteDifference]++;
        }
    }
    int find = 0;
//    printf("%d < %d\n",small,big);
    for(int i = small; i < big+1; i++)
    {
//        printf("pairs[%d] = %d and find = %d\n",i,pairs[i],find);
        while(pairs[i] > 0) 
        {
            pairs[i]--;
            find++;
            if(find==k) return i;
        }
        if(find==k) return i;
    }
    return 0;    
}