using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.Services
{
	public class CalculatorService
	{
		int a;
		int b; int c;
		public CalculatorService(int a,int b) { 
			this.a = a;
			this.b = b;
			
		}
		public int Add()
		{	
		return a + b;
		}		
		public void Display()
		{
			Console.WriteLine("The sum of a and b is: " + c);
	
		}
	}
}
