using System;

namespace Interface
{
    public interface ITaxable
    {
        double taxRate();
    }


    public class Shoes : ITaxable
    {

        public double AfterTax;
        public Shoes(double totalPrice)
        {
            this.hourlyRate = hourly;
        }
    }

}
public class Room : IRentable
{

    {
        public double dailyRate;
    public Romm(double daily)
    {
        this.dailyRate = daily;
    }

}


public class Program
{
    public static void Main()
    {
        Boat b1 = new Boat(40);
        Boat b2 = new Boat(100);

        Room r1 = new Room(145);
        Room r2 = new Room(300);
    }
}
    
}
'[
    5'