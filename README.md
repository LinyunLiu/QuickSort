# Introduction
This project assignment focuses on recreating sorting algorithm in C#, the algorithm needs 
to be efficient with n long(n) time complexity. Quick sort is one of the most efficient and 
popular algorithms that has been used for sorting. This project will apply this algorithm to sort an array with 
100, 1000, 10000 items, the items will be integer data type.

# I/O 
The input is a .txt file that contains a large set of unsorted integers
The output is also a .txt file containing the sorted integers from the input file

# QuickSort Algorithm
* There is one most important concept – pivot; it is essentially an item in an array that will be used to compare to other items. 
A new pivot will be assigned for each recursion (QuickSort algorithm is a recursive algorithm)
* In an array that is filled with integers, we conventionally choose the last item of the array as pivot, in a loop statement, 
we compare each item before the pivot.
* In details, we declare two variable indexes (i and j) of an array of integers. i is used to iterate through the array 
and compare each item with pivot, if the item is smaller than the pivot, we need to increment index j and swap 
the value of index i and index j with the help of a temp variable. (index i start from the beginning of an array, index j start from index i - 1
* Once index i has reached pivot, we need to swap the value of pivot with the value at index j+1
* After one iteration, the pivot should be put in a correct location (index) in an array. Then we need to cut the array in half 
into two arrays from the pivot. 
* Then we need to implement the same algorithm on the new 2 arrays using recursion.
