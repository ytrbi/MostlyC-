# DailyProblemSolvingTasks
# Daily Problem Solving


# Day 2: ArrayToTree
You are given an array of integers. Implement a function which creates a complete binary tree from the array (complete meaning that every level of the tree, except possibly the last, is completely filled).

The elements of the array are to be taken left-to-right, and put into the tree top-to-bottom, left-to-right.

For example, given the array [17, 0, -4, 3, 15] you should create the following tree:

    17
   /  \
  0   -4
 / \
3   15 
A tree node type is preloaded for you:

class TreeNode {

    public TreeNode left;
    public TreeNode right;
    public int value;
    
    public TreeNode(int value, TreeNode left, TreeNode right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
    
    public TreeNode(int value) 
    {
        this.value = value;
    }
    
    public override bool Equals(Object other)
    {
        ... // Already implemented for you and used in test cases 
    }
    ...
}
This kata is part of fun with trees series:

Fun with trees: max sum
Fun with trees: array to tree
Fun with trees: is perfect


# Day 3: Password Checker

 In this project you’ll make a program that measures the strength of any given password based on the following criteria. A strong password:

  is at least 8 characters long
  has lowercase letters
  has uppercase letters
  has numerical digits
  has symbols, like #, ?, !
  The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.

## how to use
> here are some example to use
  - `word` scores a 1. Weak.
  - `woRD` scores a 2. Medium.
  - `1woRD` scores a 3. Strong.
  - `2woRDsss` scores a 4. Extremely strong!
  - `2woRDsss!` scores a 5. Extremely strong again!
  - `" "` scores a 0. It’s a bunch of spaces…It doesn’t meet any of the standards.
*/