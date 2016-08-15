using System;
using System.Linq;
using System.Collections.Generic;

namespace MU.IT
{
	public static class InstructorData
	{
		public static List<Instructor> Instructors { get; set; }

		static InstructorData()
		{
			var temp = new List<Instructor>();

			AddInstructors(temp);
			//AddInstructors(temp);
			//AddInstructors(temp);
			//AddInstructors(temp);
			//AddInstructors(temp);

			Instructors = temp.OrderBy(i => i.Name).ToList();
		}

		static void AddInstructors(List<Instructor> instructors)
		{
			instructors.Add(new Instructor()
			{
				Name      = "Michael Bryant",
				Specialty = "C# and Cross-platform development",
				ImageUrl  = "images/photo1.jpg",
				Biography = "Mike has over 14 years of experience developing mobile applications. When he is not watching the Lakers play, he enjoys watching the 'Real Housewives of Milwaukee'. Go figure!"
			});

			instructors.Add(new Instructor()
			{
				Name      = "James Jones",
				Specialty = "Database Management and Development",
				ImageUrl  = "images/photo2.jpg",
				Biography = "James is a natural when it comes to designing databases, developing with SQL and managing large-scale enterprise databases. ORACLE, MySQL and SQL Server are all part of his middle names, so to speak."
			});

			instructors.Add(new Instructor()
			{
				Name      = "Jake Stephens",
				Specialty = "Systems Analysis and Design",
				ImageUrl  = "images/photo3.jpg",
				Biography = "He has been designing software for over 22 years. A published author, he has worked in teams large and small as well as a range of industries including health, security, finance and education."
			});

			instructors.Add(new Instructor()
			{
				Name      = "Nicole Tate",
				Specialty = "Mobile App development",
				ImageUrl  = "images/photo4.jpg",
				Biography = "She has been crafting software for more than 20 years."
			});

			instructors.Add(new Instructor()
			{
				Name      = "Jose Sotis",
				Specialty = "HTML5, CSS and JavaScript",
				ImageUrl  = "images/photo5.jpg",
				Biography = "He is always looking for new challenges and ways to make things better. He is also a CSS 'guru'"
			});

			instructors.Add(new Instructor()
			{
				Name      = "Jenny Motion",
				Specialty = "Product Development and Management",
				ImageUrl  = "images/photo6.jpg",
				Biography = "She enjoys building highly interactive web and mobile applications. She is often involved with community outreach work"
			});

			instructors.Add (new Instructor () {
				Name = "Chris Childs",
				Specialty = "Ethical Hacking",
				ImageUrl = "images/photo7.jpg",
				Biography = "A community advocate, a trainer and a Spartan. Enjoys cooking italian food and cheering on the Green Bay Packers. Surprise! Surprise!!"
			});

			instructors.Add(new Instructor()
			{
				Name      = "Philip Peters",
				Specialty = "All things PHP",
				ImageUrl  = "images/photo8.jpg",
				Biography = "Enjoys long walks on the beach! Won't trade his 14 cats for the world!"
			});
		}
	}
}