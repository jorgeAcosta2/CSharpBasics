/*
 * Created by SharpDevelop.
 * User: Jorge
 * Date: 8/2/2016
 * Time: 8:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FirstProgram
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter how many minutes you exercised: ");
			
			string entry = Console.ReadLine();
			Console.WriteLine(entry);
			Console.WriteLine("Press anything to exit");
			Console.ReadKey(true);
			
		}
	}
}