using System;
using Opps_Training_Playground_Day02.AccessModifierExample;
using Opps_Training_Playground_Day02.ClassMembersExample;
using Opps_Training_Playground_Day02.GenericExample;
using Opps_Training_Playground_Day02.PropertiesExample;
using Opps_Training_Playground_Day02.StructureExample;

namespace Opps_Training_Playground_Day02
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Class Member*/
			//ClassMembersExampleOutput();


			/*Access Modifier*/
			//PublicAccessModifierExampleOutput();
			//ProtectedAccessModifierOutput();

			/*Properties*/
			//PropertiesExampleOutput();

			/*Struct*/
			//StructureExampleOutput();

			/*Generics*/
			//GenericClassExampleOutput();
			GenericMethodExampleOutput();

			Console.ReadKey();
		}

		private static void ClassMembersExampleOutput()
		{
			Developer d1 = new Developer(5000);
			d1.GetSalary();
		}

		private static void PublicAccessModifierExampleOutput()
		{
			// Creating object of the class Student 
			Student S = new Student(1, "Astrid");

			// Displaying details directly 
			// using the class members 
			// accessible through another method 
			Console.WriteLine("Roll number: {0}", S.rollNo);
			Console.WriteLine("Name: {0}", S.name);

			Console.WriteLine();

			// Displaying details using  
			// member method also public 
			Console.WriteLine("Roll number: {0}", S.getRollNo());
			Console.WriteLine("Name: {0}", S.getName());
		}

		private static void ProtectedAccessModifierOutput()
		{
			X obj1 = new X();
			Y obj2 = new Y();

			// Displaying the value of x 
			Console.WriteLine("Value of x is : {0}", obj2.getX());
		}

		private static void PropertiesExampleOutput()
		{
			Person myObj = new Person();
			myObj.FirstName = "Arun";
			myObj.LastName = "Y";
			Console.WriteLine(myObj.Name);
		}

		private static void StructureExampleOutput()
		{
			Books Book1;   /* Declare Book1 of type Book */
			Books Book2;   /* Declare Book2 of type Book */

			/* book 1 specification */
			Book1.title = "C Programming";
			Book1.author = "Nuha Ali";
			Book1.subject = "C Programming Tutorial";
			Book1.book_id = 6495407;

			/* book 2 specification */
			Book2.title = "Telecom Billing";
			Book2.author = "Zara Ali";
			Book2.subject = "Telecom Billing Tutorial";
			Book2.book_id = 6495700;

			/* print Book1 info */
			Console.WriteLine("Book 1 title : {0}", Book1.title);
			Console.WriteLine("Book 1 author : {0}", Book1.author);
			Console.WriteLine("Book 1 subject : {0}", Book1.subject);
			Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

			/* print Book2 info */
			Console.WriteLine("Book 2 title : {0}", Book2.title);
			Console.WriteLine("Book 2 author : {0}", Book2.author);
			Console.WriteLine("Book 2 subject : {0}", Book2.subject);
			Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

			Console.ReadKey();
		}

		private static void GenericClassExampleOutput()
		{
			// instance of string type 
			GFG<string> name = new GFG<string>();
			name.value = "GeeksforGeeks";

			// instance of float type 
			GFG<float> version = new GFG<float>();
			version.value = 5.0F;

			// display GeeksforGeeks 
			Console.WriteLine(name.value);

			// display 5 
			Console.WriteLine(version.value);
		}

		private static void GenericMethodExampleOutput()
		{
			// creating object of class GFG 
			GenericMethod p = new GenericMethod();

			// calling Generics method 
			p.Display<int>("Integer", 122);
			p.Display<char>("Character", 'H');
			p.Display<double>("Decimal", 255.67);
		}
	}
}
