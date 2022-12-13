# Algorithms
A repository where sorting and searching algorithms will be written in C#. 

## Sorting Algorithms

  1. Bubble Sort
  2. Selection Sort
  
  
### Bubble Sort

  We will start our journey into sorting algorithms with the bubble sort. It is called bubble sorting because as the bigger bubble goes upward and passes the smaller bubbles, the bigger number goes on the right and the smaller number goes to the left (or to the opposite side if you want to do it that way). It is for sure that the biggest number will go to the right in the first iteration, and the other numbers will follow along in the next iterations. We will also use a flag to let us know when the sorting is complete before it finishes all the iterations.
  
  
### Selection Sort

  With the selection sort, the element with the minimum value is found inside the array, and the position is swapped with the first element. In the next iteration, the second element is swapped with the element of the minimum value, except for the first element, which is smaller because of the first iteration. We continue this procedure till the entire array is sorted.
  
  ---
  
  
  ## Searching Algorithms

  1. Binary Search
  
  
### Binary Search

 The binary search is the second in the "row" of the search algorithms. The first is the linear search, which we will not code because it is easy. It is a for-loop that iterates the whole table until it finds the element we seek. Starting with the binary search, the first thing to do is sort the table. After that, we should find the midpoint. Then we check if the value we need is this midpoint value or if it is greater or not. Afterwards, we split the table into two smaller tables. If the element we seek is greater than the element in the middle, we take the right subtable, and if the element is smaller than the element in the middle, we take the left subtable. This happens when we sort our table ascending. Otherwise, the binary search is the same, but for greater values we take the left subtable and for lesser values we take the right. We find the element we want when it has the middle value.

