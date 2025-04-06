namespace Algorithms.TwoPointers.Palindrome;

    public class Solution {
        public static bool IsPalindrome1(string s)
        {
            s = s.ToUpper();
            int length = s.Length;
            int head = 0;
            int tail = length-1;
        
            while(s[head] == s[tail]){
                if(s[head] == ' '){
                    head++;
                    length--;
                    continue;
                }
        
                if(s[tail] == ' '){
                    tail--;
                    length--;
                    continue;
                }
            
                if(head == ((length-1)/2)){
                    return true;
                }
                head++;
                tail--;
            }
            return false;
        }
        
        public static bool IsPalindrome2(string s) {
            int left = 0;
            int right = s.Length - 1;
            while (left < right) {
                if (s[left] != s[right]) {
                    return false;
                }
                left = left + 1;
                right = right - 1;
            }
            return true;
        }
        
        public static void Main(string[] args) {
            List<string> inputs = new List<string>()
            {
                "kaYak",
                "hello",
                "RaCEACAR",
                "A",
                "ABCDABCD"
            };

            for (int i = 0; i < inputs.Count; i++)
            {
                Console.WriteLine("1. Approach --> " + (i+1)+": "+ IsPalindrome1(inputs[i]));
                Console.WriteLine("2. Approach --> " + (i+1)+": "+ IsPalindrome2(inputs[i]));
            }
        }
    }
