using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Car blueCar = new Car("blue");
        Garage smallGarage = new Garage(2);

        smallGarage.ParkCar(blueCar, 0);
        Console.WriteLine(smallGarage.Cars);
        try
        {
          Car car = getCar(smallGarage);
          Console.WriteLine(car.Color);
        }catch{
            Console.WriteLine("No car found");
        }


    }
     public Car getCar(Garage myCars)
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
    //  List<Person> people = new List<Person>();
   
    public Car(string initialColor)
    {
        Color = initialColor;
        // Person person1 = new Person("James", "Smith");
        // Person person2 = new Person("Jane", "Ann");
        // people.Add(person1);
        // people.Add(person2);

    }

    public string Color { get; private set; }
}

public class Garage
{
    private Car[] cars;

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
                }
            }
            return "That's all!";
        }
    }
    public string getUserCar()
    {
        Console.WriteLine("What car would you like?");
        string carChoice = Console.ReadLine();
        return carChoice;

    }
    
    class Person
    {
        string firstName;
        string lastName;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}


