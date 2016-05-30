﻿using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoPhoneBook
{

    [BsonIgnoreExtraElements]
    public class Person
    {
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Phonebook");
            var collection = database.GetCollection<Person>("Person");
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("0 - out from app");
                Console.WriteLine("1 - add person");
                Console.WriteLine("2 - find by name");
                Console.WriteLine("3 - find by phone");
                Console.WriteLine("4 - output phonebook");
                Console.WriteLine("5 - delete all person from phonebook");
                Console.Write("Input: ");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "0":
                        isWork = false;
                        break;
                    case "1":
                        AddPerson(collection);
                        break;
                    case "2":
                        FindByName(collection);
                        break;
                    case "3":
                        FindByNumber(collection);
                        break;
                    case "4":
                        ListOutput(collection);
                        break;
                    case "5":
                        collection.DeleteMany(a => a.Number != null || a.Name != null);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }

        private static void AddPerson(IMongoCollection<Person> collection)
        {
            var newPerson = new Person();
            Console.Write("Input name: ");
            newPerson.Name = Console.ReadLine();
            Console.Write("Input number: ");
            newPerson.Number = Console.ReadLine();
            collection.InsertOne(newPerson);
        }

        private static void FindByName(IMongoCollection<Person> collection)
        {
            Console.Write("Input name: ");
            string inputName = Console.ReadLine();
            var phonebook = collection.Find(new BsonDocument()).ToList();
            foreach (var person in phonebook)
            {
                if (person.Name == inputName)
                {
                    Console.WriteLine("{0}", person.Number);
                    return;
                }
            }
            Console.WriteLine("Person with this name is absent");
        }

        private static void FindByNumber(IMongoCollection<Person> collection)
        {
            Console.Write("Input number: ");
            string inputNumber = Console.ReadLine();
            var phonebook = collection.Find(new BsonDocument()).ToList();
            foreach (var person in phonebook)
            {
                if (person.Number == inputNumber)
                {
                    Console.WriteLine("{0}", person.Name);
                    return;
                }
            }
            Console.WriteLine("Person with this number is absent");
        }

        private static void ListOutput(IMongoCollection<Person> collection)
        {
            var list = collection.Find(new BsonDocument()).ToList();
            foreach (var node in list)
            {
                Console.WriteLine("{0} {1}", node.Name, node.Number);
            }
        }
    }

}
