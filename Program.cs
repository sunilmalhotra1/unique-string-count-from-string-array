class Program
	{

        static void Main(string[] args)
		{
			    String[] input = {"abcd", "acbd", "adcb", "cdba", "bcda", "badc","sstvz","zvsst","wxvsl"};

			    foreach (var item in input)
			    {
				    Console.WriteLine(item);
			    }
			    Console.WriteLine(checkMatchedCombinationOfStrings(input));
			    Console.ReadKey();
		}
        
       static string sortString(string str)
		{

            string sortedString = string.Empty;
            int[] indexArray = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
            indexArray[i] = str[i];
            if (i > 0)
            {
                for (int j = 0; j <= i; j++)
                {
                if (indexArray[j] > indexArray[i])
                {
                    indexArray[i] = indexArray[i] + indexArray[j];
                    indexArray[j] = indexArray[i] - indexArray[j];
                    indexArray[i] = indexArray[i] - indexArray[j];
                }
                }
            }

            }
            for (int i = 0; i < indexArray.Length; i++)
            {
            sortedString += ((char)indexArray[i]).ToString();
            }
            return sortedString;
	    }
        static int checkMatchedCombinationOfStrings(String[] input)
        {
            HashSet<String> set = new HashSet<String>();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
              var charArraySet = sortString(input[i]);
              if (!set.Contains(charArraySet))
              {
                set.Add(charArraySet);
                counter++;
              }
            }
            return counter;
        }
    }
