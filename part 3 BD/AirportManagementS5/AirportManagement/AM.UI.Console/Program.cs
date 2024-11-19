﻿// See https://aka.ms/new-console-template for more information


using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");

Plane plane = new Plane();
plane.Capacity = 100;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Airbus;

//Plane plane2 = new Plane(200,new DateTime(2024,12,11,12,12,00),PlaneType.Boeing);
//Initialiseur d'objets
Plane plane2 =  new Plane{Capacity=200,PlaneType=PlaneType.Boeing,
    ManufactureDate= new DateTime(2024, 12, 11, 12, 12, 00) };
Console.WriteLine(plane);
Passenger p1 = new Passenger { FirstName="EYA",
                               LastName="BOUKHZAR",
                               EmailAddress="EYA.BOUKHZAR@esprit.tn"};
Console.WriteLine("*****CheckProfile********");
Console.WriteLine(p1.CheckProfile("Amina", "Aoun"));
Console.WriteLine(p1.CheckProfile("amina", "aoun","abc"));
Staff s1 = new Staff{FirstName="Staff1"};
Traveller t1 = new Traveller { FirstName = "Traveller1" };
Console.WriteLine("*****PassengerType********");
p1.PassengerType();
s1.PassengerType();
t1.PassengerType();
FlightMethods fm= new FlightMethods();
fm.Flights = TestData.listFlights;
Console.WriteLine("*****GetFlightDates********");
foreach(DateTime d in fm.GetFlightDates("Paris"))
    Console.WriteLine(d);
Console.WriteLine("*****GetFlights********");
fm.GetFlights("Destination", "Madrid");
fm.GetFlights("EstimatedDuration", "100");
Console.WriteLine("*******ShowFlightDetails*******");
fm.ShowFlightDetails(TestData.BoingPlane);
Console.WriteLine("*****OrderedDurationFlights*****");
foreach(Flight f in fm.OrderedDurationFlights())
    Console.WriteLine(f);
Console.WriteLine("*********DurationAverage*********");
Console.WriteLine(fm.DurationAverage("Paris"));
Console.WriteLine("appel avec delegate");
Console.WriteLine(fm.DurationAverageDel("Paris"));
Console.WriteLine("*************ProgrammedFlightNumber******");
Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2021,12,31)));
Console.WriteLine("*************SeniorTravellers******");
foreach(Traveller t in fm.SeniorTravellers(TestData.flight1))
    Console.WriteLine(t);
Console.WriteLine("********DestinationGroupedFlights*******");
fm.DestinationGroupedFlights();
Console.WriteLine("*******UpperFullName**********");
p1.UpperFullName();
Console.WriteLine(p1.FirstName+" "+p1.LastName);
