using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializationIntro
{
    static class Program
    {
        static void Main(string[] args)
        {
            //
            var xmlFilePath = @"C:\revature\phat-code\Person.xml";
            var jsonFilePath = @"C:\revature\phat-code\Person.json";

            var data = GetInitialData();
              
            //var data = DeserializeXmlFromFile(xmlFilePath);

            //ModifyData(data);

            SerializeXmlToFile(xmlFilePath, data);
            SerializeJsonToFile(jsonFilePath, data);
        }


        public static void SerializeJsonToFile(string jsonFilePath, List<Person> data)
        {
            // we will do this with JSON.NET aka Newtonsoft Json
            // we use NuGet to get these dependencies
            string json = JsonConvert.SerializeObject(data);

            // exceptions should be handled here, ignored for sake of time
            File.WriteAllText(jsonFilePath, json);

            //switching from sync to async:
            /*
             * ->call the async version 
             * ->await the task returned by the method
             * ->add the async modifier to the method
             * ->make the method to return a task
             * ->add "Async" suffix to the name of the mothod
             * repeat from step 1 on up to any callers on the method
             */
        }

        public static void ModifyData(List<Person> data)
        {
            var person = data[0];
            person.Id += 10;
        }

        public static List<Person> DeserializeXmlFromFile(string xmlFilePath)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));

            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(xmlFilePath, FileMode.Open);

                return (List<Person>)serializer.Deserialize(fileStream);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error while opening {xmlFilePath} for writing: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error while serializing: {ex.Message}");
            }
            finally // finally block always runs whether, no-exception, handled-exception, or unhandled-exception
            {
                // this "do something if not null"
                //if (fileStream != null)
                //{
                //    fileStream.Dispose();
                //}
                fileStream?.Dispose(); // is exact same as commented-out code above
                // null-conditional operator
            }
            return null;
        }

        public static void SerializeXmlToFile(string xmlFilePath, List<Person> data)
        {
            // XmlSerializer was made pre-generics and has not been updated
            var serializer = new XmlSerializer(typeof(List<Person>));

            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(xmlFilePath, FileMode.Create);

                serializer.Serialize(fileStream, data);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error while opening {xmlFilePath} for writing: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error while serializing: {ex.Message}");
            }
            finally // finally block always runs whether, no-exception, handled-exception, or unhandled-exception
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        public static List<Person> GetInitialData()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Billy",
                    Address = new Address
                    {
                        Street = "123 Main St",
                        City = "Dallas",
                        State = "TX"
                    }
                },
                new Person
                {
                    Id = 2,
                    Name = "Sam"
                }
            };
        }
    }
}