using System;
 namespace week6_1
{
    class Manufacture
    {
        public static void Main(string[] args)
        {
            Car bmw = new Car(2,"BMW");
            Car audi = new Car(2,"Audi");
            
            Truck ford = new Truck(4,"Ford");
            Truck crysler = new Truck(4,"Crysler");
             Console.WriteLine(string.Format("The manufacture is {1} and the car has {0} spots available for passengers.",bmw.spots, bmw.Type));
            Console.WriteLine(string.Format("The manufacture is {1} and the car has {0} spots available for passengers.",audi.spots, audi.Type));
            Console.WriteLine(string.Format("The manufacture is {1} and the truck has {0} spots available for passengers.",ford.Spots, ford.Type));
            Console.WriteLine(string.Format("The manufacture is {1} and the truck has {0} spots available for passengers.",crysler.Spots,crysler.Type));
            
        }
    }
    public interface IcheckCar
    {
        int getAvaiableSeat();
        string getVehicle();
    }
    class Car : IcheckCar
    {
        public int Spots;
        public string Type;
         public Car(int spots,string type)
        {
            this.spots = spots;
            this.Type = type;
        }
        public int spots
        {
            get;
            set;
        }
        public string type 
        {
            get;
            set;
        }
        int IcheckCar.getAvaiableSeat()
        {
            return spots;
        }
        string IcheckCar.getVehicle()
        {
            return type;
        }
    }
    class Truck : IcheckCar
    {
        public int Spots;
        public string Type;
         public Truck(int spots, string type)
        {
            this.Spots = spots;
            this.Type = type;
        }
        public int spots
        {
            get;
            set;
        }
        public string type
        {
            get;
            set;
        }
        int IcheckCar.getAvaiableSeat()
        {
            return spots;
        }
        string IcheckCar.getVehicle()
        {
            return type;
        }
    }
}