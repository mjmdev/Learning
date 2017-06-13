/*
    URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
            has sufficient space at the end to hold the additional characters, and that you are given the "true"
            length of the string. 
 */

 public string URLify(char[] chars, int length)
 {
     int spaceCount = 0;
     for (int i = 0; i < length; i++)
     {
         if (url[i] == ' ')
            spaceCount++;
     }
             
     int index = (length + spaceCount * 2) - 1;
     for (int i = length - 1; i >= 0; i--)
     {
        if (chars[i] != ' ')
        {
            chars[index] = chars[i];
            index--;
        }
        else
        {
            chars[index] = '0';
            chars[index - 1] = '2';
            chars[index - 2] = '%'
            index = index - 3;
        }
     }

     string str = String.Join('', chars);

     return str.Trim();
 }