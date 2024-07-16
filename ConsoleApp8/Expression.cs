using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Expression
    {
        /*
         * Tests:
         * null = true
         * {} = true
         * "{Am[ir|{Ha}|[|laby|514}" = true
         * "{Amir}|457|x|556|123||" = true
         * "{4[i{|H{a}|464}5[5|l|5]14]}" = ture
         *
         * "{Am[ir|{H|a}|[|laby|514}" = false
         * "{Amir}|457||x|556|123||" = false
         * "{4[i{|H{a}|4|64}5[5|l|5]14]}" = false                        
         */

        public static bool ValidationExpression(string str)
        {
            if (str == null) { return true; }
            if (str.Length == 0) { return true; }
            char[] openParenthesis = {  '{', '[', '|' };
            char[] closeParenthesis = { '}', ']', '|' };
            bool counterSpecialParenthesis = false;
            Stack<char> openParenthesisStack = new Stack<char>();
            for(int i=0; i < str.Length; i++)
            {
                // When open parenthesis insert into the stack
                // The special Parenthesis check if is odd and inert into the stack also. 
                if (str[i] == openParenthesis[2] && counterSpecialParenthesis ==false)
                {
                    counterSpecialParenthesis = true;
                    openParenthesisStack.Push(str[i]);
                    continue;
                }
                if (str[i] == openParenthesis[0]  || str[i] == openParenthesis[1])
                {
                    openParenthesisStack.Push(str[i]);
                }
                // When holding close parenthesis we will match it to the last parenthesis opened that located first parenthes in stack.
                if (str[i] == closeParenthesis[0])
                {
                    if (openParenthesisStack.Pop() != openParenthesis[0])
                        return false;
                }
                if (str[i] == closeParenthesis[1])
                {
                    if (openParenthesisStack.Pop() != openParenthesis[1])
                        return false;
                }
                if (str[i] == closeParenthesis[2] && counterSpecialParenthesis == true)
                {
                    counterSpecialParenthesis = false;
                    if (openParenthesisStack.Pop() != openParenthesis[2])
                        return false;
                }
            }
            return (openParenthesisStack.Count == 0) ? true : false;
             
        }
    }
}
