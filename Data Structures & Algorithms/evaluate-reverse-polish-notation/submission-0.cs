public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int result))
            {
                stack.Push(result);
            }
            else
            {
                int first = stack.Pop(); 
                int second = stack.Pop(); // in the stack

                if(token == "+")
                    stack.Push(first + second);
                else if(token == "-")
                    stack.Push(second - first);
                else if(token == "*")
                    stack.Push(first * second);
                else if(token == "/")
                    stack.Push(second / first);
            }
        }
        return stack.Pop();
    }
}
