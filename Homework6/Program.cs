
using Homework.Hellper;


Console.WriteLine("People names starting with R:");
AccessData.PEOPLE.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList().ForEach(Console.WriteLine);


Console.WriteLine("Brown dogs older than 3:");
AccessData.DOGS.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).ToList().ForEach(Console.WriteLine);


Console.WriteLine("People with more than 2 dogs:");
AccessData.PEOPLE.Where(x => x.Dogs.Count > 2).OrderByDescending(o => o.FirstName).ToList().ForEach(Console.WriteLine);


Console.WriteLine("Nathen first dog:");
Console.WriteLine(" Name:" + AccessData.PEOPLE.FirstOrDefault(x => x.FirstName == "Nathen").Dogs.First().Name);



Console.WriteLine("Freddy's dogs older than one year");
AccessData.PEOPLE.FirstOrDefault(x => x.FirstName == "Freddy").Dogs.Where(dog => dog.Age > 1).ToList().ForEach(Console.WriteLine);


Console.WriteLine("People with white dogs");
AccessData.PEOPLE.SelectMany(p => p.Dogs).Where(p => p.Color == "White").OrderBy(p => p.Name).ToList().ForEach(Console.WriteLine);
