using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Car blueCar = new Car("blue");
        Car redCar = new Car("red");
        Car greenCar = new Car("green");
        Car orangeCar = new Car("orange");
        Garage smallGarage = new Garage(4);
        
        Person person1 = new Person("James", "Smith");
        Person person2 = new Person("Jane", "Ann");
        Person person3 = new Person("Robert", "Class");
        Person person4 = new Person("Lisa", "George");

        blueCar.addPerson(person1);
        orangeCar.addPerson(person2);


        smallGarage.ParkCar(blueCar, 0);
        smallGarage.ParkCar(orangeCar,1);
        smallGarage.ParkCar(redCar,2);
        smallGarage.ParkCar(greenCar,3);
        
        
    for ( int i =0; i < 1; i++){
        try
        {
            Car car = getCar(smallGarage);

            Console.WriteLine("Enter your first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Person person = new Person(firstname,lastName);
            car.addPerson(person);

        }
        catch
        {
            Console.WriteLine("No car found");
        }
    }

        Console.WriteLine(smallGarage.Cars);
    }
    public static string getUserCar()
    {
        Console.WriteLine("What car would you like?");
        string carChoice = Console.ReadLine().ToLower();
        return carChoice;

    }
    public static Car getCar(Garage myCars)
    {
        string userCar = getUserCar();
        foreach (Car car in myCars.cars)
        {
            if (car.Color == userCar)
            {
                return car;
            }
        }
        return null;

    }

}
public class Car
{
    List<Person> people;

    public Car(string initialColor)
    {
        people = new List<Person>();
        Color = initialColor;


    }
    public void addPerson(Person person)
    {
        people.Add(person);

    }
    public void getPeople()
    {
        foreach (Person p in people)
        {
            Console.WriteLine("{0} " + "{1} ", p.firstName, p.lastName);
        }
    }

    public string Color { get; private set; }
}

public class Garage
{
    public Car[] cars { get; private set; }

    public Garage(int initialSize)
    {
        Size = initialSize;
        this.cars = new Car[initialSize];
    }

    public int Size { get; private set; }

    public void ParkCar(Car car, int spot)
    {
        cars[spot] = car;
    }

    public string Cars
    {
        get
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null)
                {
                    Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                    cars[i].getPeople();
                }
            }
            return "That's all!";
        }
    }
}
public class Person
{

    public string firstName { get; private set; }
    public string lastName { get; private set; }
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

}
