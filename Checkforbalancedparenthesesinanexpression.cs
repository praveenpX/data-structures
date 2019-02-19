public class Prgram
{
	public static void Main(string[] args)
	{
		List<string> brs = new List<string>();

		brs.Add("{}[]()");
		brs.Add("{[}]");

		var results = areBracesBalancedArray(brs.ToArra());

		foreach(var r in results)
		{
			Console.WriteLine(r);
		}

	}


	// Complete the braces function below.
    static string[] areBracesBalancedArray(string[] values) {
        
        List<string> result = new List<string>();
        
        foreach(string item in values)
        {
            if(areBracesBalanced(item))
            {
              result.Add("YES");  
            }
            else{
                result.Add("NO");
            }   
        }
        return result.ToArray();
    }
    
    static bool areBracesBalanced(string s)
    {
        char[] chars = s.ToArray();
        
        Stack<Char> brstack = new Stack<Char>(); //LIFO
        
        // only add opening braces to stack, and for each others, pop stack and check for matches
        
        for(int i =0; i < chars.Length; i++)
        {
            if(chars[i] == '{' || chars[i] == '[' || chars[i] == '(') //start adding opening braces to stack
            {
                brstack.Push(chars[i]);
            }
            
            if(chars[i] == '}' || chars[i] == ']' || chars[i] == ')')
            {
                if(brstack.Count == 0) //first element check no elements in the stack, so no matching
                {
                    return false;
                }
                else if(!checkForMatchingPair(brstack.Pop(), chars[i])) //else check for matching paits, if true continue, if false break
                {
                    return false;
                }
            }
        }
        
        if(brstack.Count == 0) // will be 0 if all the pairs matched so return true
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool checkForMatchingPair(char c1, char c2)
    {
        //check for '{', '[', ')'
        
        if(c1 == '{' && c2 == '}')
        {
            return true;
        }
        else if(c1 == '[' && c2 == ']' )
        {
            return true;
        }
        else if(c1 == '(' && c2 == ')')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
