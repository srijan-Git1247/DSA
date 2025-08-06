using System;
using System.Collections.Generic;

public class Program {
  public static int[] TwoNumberSum(int[] array, int targetSum) {
    bool doSearch=true;
		List<int> intList=new List<int>();
    	for(int i=0 ;i<array.Length && doSearch ;i++)
		{	
			for(int j=0;j<array.Length;j++)
			{
				if(array[i]!=array[j] && array[i]+array[j]==targetSum)
				{
						
					intList.Add(array[i]);
					intList.Add(array[j]);
					doSearch=false;
					break;
				
				}
	
			}
	
		}
		if(intList.Count==0)
		{
			return new int[0];
		
		
		}
  		return intList.ToArray();
  
  }
}
