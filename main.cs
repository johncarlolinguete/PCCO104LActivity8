using System;


public abstract class Vehicle
{

    protected string _make;
    protected string _model;
    protected int _year;
    protected string _color;
    protected double _price;
    protected bool _isRunning;


    public Vehicle(string make = "Unknown", string model = "Unknown", int year = -1, string color = "Unknown", double price = 0.0)
    {
        _make = make;
        _model = model;
        _year = (year == -1) ? DateTime.Now.Year : year;
        _color = color;
        _price = price;
        _isRunning = false;
    }


    public void Start()
    {
        _isRunning = true;
        Console.WriteLine("The vehicle has started.");
    }

    public void Stop()
    {
        _isRunning = false;
        Console.WriteLine("The vehicle has stopped.");
    }

    protected void DisplayDetails()
    {
        Console.WriteLine($"Make: {_make}");
        Console.WriteLine($"Model: {_model}");
        Console.WriteLine($"Year: {_year}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Price: ${_price}");
        Console.WriteLine($"IsRunning: {_isRunning}");
    }

    public virtual void ShowVehicleDetails()
    {
        DisplayDetails();
    }
}


public class ElectricCar : Vehicle
{
    private int _batteryCapacity;

    public ElectricCar(string make = "Unknown", string model = "Unknown", int year = -1, string color = "Unknown", double price = 0.0, int batteryCapacity = 0)
        : base(make, model, year, color, price)
    {
        _batteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine("Charging the electric car.");
    }

    public override void ShowVehicleDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Battery Capacity: {_batteryCapacity} kWh");
    }
}


public class SportsCar : Vehicle
{
    private int _topSpeed;

    public SportsCar(string make = "Unknown", string model = "Unknown", int year = -1, string color = "Unknown", double price = 0.0, int topSpeed = 0)
        : base(make, model, year, color, price)
    {
        _topSpeed = topSpeed;
    }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating the sports car.");
    }

    public override void ShowVehicleDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Top Speed: {_topSpeed} mph");
    }
}


public class Truck : Vehicle
{
    private int _payloadCapacity;

    public Truck(string make = "Unknown", string model = "Unknown", int year = -1, string color = "Unknown", double price = 0.0, int payloadCapacity = 0)
        : base(make, model, year, color, price)
    {
        _payloadCapacity = payloadCapacity;
    }

    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo into the truck.");
    }

    public override void ShowVehicleDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Payload Capacity: {_payloadCapacity} lbs");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        ElectricCar electricCar = new ElectricCar("Tesla", "Model S", 2022, "Black", 80000, 100);
        SportsCar sportsCar = new SportsCar("Ferrari", "488 GTB", 2020, "Red", 250000, 205);
        Truck truck = new Truck("Ford", "F-150", 2021, "White", 35000, 2000);

        
        electricCar.Start();
        sportsCar.Accelerate();
        truck.LoadCargo();

        
        electricCar.ShowVehicleDetails();
        sportsCar.ShowVehicleDetails();
        truck.ShowVehicleDetails();
    }
}
