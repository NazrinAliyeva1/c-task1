﻿////task1
//int first = 1568;
//while (first != 0)
//{
//    int max = first % 10; //max=2
//    int second = first / 10; // second=1
//    while (second != 0)
//    {
//        if (second % 10 > max)
//        {
//            max = second % 10;
//            break;

//        }
//        second /= 10;
//    }
//    Console.WriteLine(max);
//    break;
//}

////task2
//int num = 16;
//if (num % 2 == 0)
//{
//    num /= 2;
//    Console.WriteLine("Qüvvetidir.");
//}
//else if (num == 1)
//{
//    Console.WriteLine("Qüvvetidir.");
//}
//else
//{
//    Console.WriteLine("Qüvveti deyil.");
//}

////task3
//int[] nums = { 3, 4, 5, 7,9};
//int min = nums[0];
//int max = nums[0];
//int sum = min + max;

//for (int i = 1; i < nums.Length; i++)
//{
//    if (min < nums[i])
//    {
//        min = nums[i];
//    }
//    if (max > nums[i])
//    {
//        max = nums[i];
//    }
//    sum = min + max;
//    Console.WriteLine(sum);

//}


////task4
//    int[] nums = { 1,3,5,9,39,77};
//int count = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 != 0 && nums[i] % 3 == 0)
//    {
//        count = count + 1;
//    }
//}

//Console.WriteLine(count);


//task5
//int[] nums = { 5, 9, 12, 11 };

//int count = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    for (int j = 2; j < nums[i]; j++)
//    {
//        if (nums[i] % j == 0)
//        {
//            count += 1;
//            break; // murekkeb olmayan bir num[i] tapmayandanda ic donguden cixiriq
//        }
//    }
//}
//Console.WriteLine(count);



