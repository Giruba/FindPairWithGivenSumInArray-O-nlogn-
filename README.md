### Author : Giruba Beulah SE

# FindPairWithGivenSumInArray-O-nlogn-
C# program for printing the pair of elements in the array whose sum is equal to a given number

1. Sort the array
2. Initialize two indices, one for startPosition [0] and one for endPosition [array.Length -1]
3. If the elements at startPosition and endPosition equal the sum, print the sum, incrementing both the positions to find more pairs
4. If the sum in step 3 was greater than the expected sum, decrement endPosition
5. If the sum in step3 was lesser than teh expected sum, increment startPosition
