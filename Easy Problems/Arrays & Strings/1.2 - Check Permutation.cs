/* 
    Problem 1.2
    Check Permutation: Given two strings, write a method to decide if one is a permutation of the other. 

    Assumptions:
    1) White spaces not significant
    2) Capitalization not significant
    3) Ascii characters
 */

 // Approach 1 - Sort strings and compare
public bool IsPermutation(string s, string t)
{
    if (s.Length != t.Length) { return false; }

    string sSorted = Sort(s);
    string tSorted = Sort(t);

    bool isPermutation = (s == t);
    return isPermutation;
}

 public string Sort(string str)
 {
     char[] chars = str.ToCharArray();
     Array.Sort(chars);
     return String.Join("", chars);
 }

 // Approach 2 - Keep track of character count
 public bool IsPermutationChar(string s, string t)
 {
     if (s.Length != t.Length) { return false; }

     int[] chars = new int[128];
     for (int i = 0; i < s.Length; i++)
     {
         int val = s[i];
         chars[val]++;
     }

     for (int i = 0; i < t.Length; i++)
     {
         int val = t[i];
         chars[val]--;

         if (chars[val] < 0) 
         {
             return false;
         }
     }

     return true;
 }