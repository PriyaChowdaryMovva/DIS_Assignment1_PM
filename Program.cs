using System;
using System.Text.RegularExpressions;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "cccc"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string = Regex.Replace(s, "[aeiouAEIOU]", ""); //Finding the vowels by using the regular expression pattern and replacing them with "".
                return final_string; //Return the modified string to the main program
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string s1 = "";
                string s2 = "";
                for (int i = 0; i < bulls_string1.Length; i++)  //Converting String array1 to a String s1 by concatinating all array elements
                    s1 = s1 + bulls_string1[i];
                for (int i = 0; i < bulls_string2.Length; i++) //Converting String array2 to a String s2 by concatinating all array elements
                    s2 = s2 + bulls_string2[i];
                if (s1 == s2) //Comparing both the final strings
                    return true; //Return true to main program if both strings are equal
                else
                    return false; //Return false to main program if both strings are not equal
                
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int ans = 0;
                int i, j;
                for (i = 0; i < bull_bucks.Length; i++)  // to loop for every element in the array
                {
                    if ((bull_bucks.Length > 0 && bull_bucks.Length <= 100) && (bull_bucks[i] > 0 && bull_bucks[i] <= 100)) //Checking for constraints
                    {
                        for (j = 0; j < bull_bucks.Length; j++) //nested loop to compare every element with other elements in the array
                        {
                            if (bull_bucks[i] == bull_bucks[j] && i != j) // if duplicate element, break from the loop
                                break;
                        }
                        if (j == bull_bucks.Length) // unique element found after comparing with all other elements
                        {
                            ans = ans + bull_bucks[i];   //adding all unique elements                  
                        }
                    }
                }
                return ans; //returning the sum to the main program to display the output
            }        
                       
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int rowSize = Convert.ToInt32(Math.Sqrt(bulls_grid.Length)); //Getting the number of rows
                int columnSize = Convert.ToInt32(Math.Sqrt(bulls_grid.Length)); //Getting the number of columns
                int i = 0, j = 0, k = 0, l = 0, sum1 = 0, sum2 = 0;
                int mid = rowSize / 2; //Formula to calculate the middle element index
                for (i = 0; i < rowSize; i++) //Loop for the primary diagonal
                {
                    for (j = 0; i < columnSize; j++)
                    {
                        if (i == j) //Checking for the elements belonging to the primary diagonal
                        {
                            sum1 = sum1 + bulls_grid[i, j]; //Sum of primary diagonal elements
                            i += 1;
                            j += 1;
                        }

                    }
                }
                for (k = 0; k < rowSize; k++) //Loop for the secondary diagonal
                {
                    for (l = 0; l < columnSize; l++)
                    {
                        if ((k + l) == (rowSize - 1)) //Checking for the elements belonging to the secondary diagonal
                            sum2 += bulls_grid[k, l]; //Sum of secondary diagonal elements
                    }
                }
                if (rowSize % 2 != 0) //for odd sized matrix
                    return (sum1 + sum2 - (bulls_grid[mid, mid])); //removing the middle array element that is counted twice
                else //for even sized matrix
                    return (sum1 + sum2);                
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                int n = bulls_string.Length; //getting the length of the string and the array
                char[] ch = bulls_string.ToCharArray(); //converting the given string to a char array
                char[] new_ch = new char[n]; //creating a new char array to store the result string
                if (bulls_string.Length == indices.Length && n > 0 && n <= 100)
                    for (int i = 0; i < n; i++)
                    {
                        new_ch[indices[i]] = bulls_string[i];   //rearranging the given string and storing the new result in the char array          
                    }
                return new string(new_ch); //passing the final result to the main program
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                foreach (char c in bulls_string6)  //running a loop to check all characters in the string
                {
                    if (c == ch) //implement the below logic if the given character is present in the string
                    {
                        string[] words = bulls_string6.Split('c'); //Splitting the given string into an array
                        string s1 = words[0]; //string before the occurance of the given character
                        string s2 = words[1]; //string after the occurance of the given character
                        char[] cArray = s1.ToCharArray(); //Converting the string s1 to an array of characters
                        string reverse = String.Empty; //Creating an empty string to store the reversed string
                        for (int i = cArray.Length - 1; i > -1; i--) //looping over the character array from ending to starting to get the reverse string
                        {
                            reverse += cArray[i]; //forming the reverse string by concatinating characters from end to start
                        }
                        string res = ch + reverse + s2; //getting the final string by adding the character, the reversed string and the remaining original string
                        return res; //returning the result to the main program
                    }
                    else
                    {
                        continue; //continue the foreach loop to check the original string
                    }
                }
                return bulls_string6; //If the given character is not present in the original string, return the original string           

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}