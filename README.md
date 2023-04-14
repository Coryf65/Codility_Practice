# Codility Tests

All answers written in C#

- [Smallest Positive Int](#smallestpositiveint) that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
- [BinaryGap](#binarygap) Find longest sequence of zeros in binary representation of an integer. 


## Smallest Positive Int

> that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

### Problem :

This is a demo task.

Write a function:

`class Solution { public int solution(int[] A); }`

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given `A = [1, 3, 6, 4, 1, 2]`, the function should return `5`.

Given `A = [1, 2, 3]`, the function should return `4`.

Given `A = [−1, −3]`, the function should return `1`.

Write an efficient algorithm for the following assumptions:

- N is an integer within the range [1..100,000];
- each element of array A is an integer within the range [−1,000,000..1,000,000].

>Copyright 2009–2023 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 

GIVEN
```C#
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Implement your solution here
    }
}
```

*my answer is in class `SmallestPositiveInt.cs`*
___

##  BinaryGap

Find longest sequence of zeros in binary representation of an integer.

A `binary gap` within a `positive integer N` is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number `9` has binary representation `1001` and contains a binary gap of length `2`. The number `529` has binary representation `1000010001` and contains two binary gaps: one of length `4` and one of length `3`. The number `20` has binary representation `10100` and contains one binary gap of length `1`. The number `15` has binary representation `1111` and has `no` binary gaps. The number `32` has binary representation `100000` and has `no` binary gaps.

Write a function:
```C#
class Solution { public int solution(int N); }
```
that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given `N = 1041` the function should return `5`, because N has binary representation `10000010001` and so its longest binary gap is of length `5`. Given `N = 32` the function should return `0`, because `N` has binary representation `'100000'` and thus `no` binary gaps.

Write an efficient algorithm for the following assumptions:

- `N` is an integer within the range `[1..2,147,483,647]`

