﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class TestData
    { public static plane Boingplane = new plane { planeType = planeType.Boeing, Capacity = 150, ManufactureDate = new DateTime(2015, 02, 03) };
      
       public static plane  Airbusplane= new plane {planeType=planeType.Airbus,Capacity=,Manufacture=new DateTime(2020,01,01)};
        // Staffs
        public static Staff captain = new Staff { FullName = new FullName { FirstName = "captain", LastName = "captain" }, EmailAddress = "captain.captain@gmail.com", BirthDate = new DateTime(1965, 01, 01), EmployementDate = new DateTime(1999, 01, 01), Salary = 99999 };
        public static Staff hostess1 = new Staff { FullName = new FullName { FirstName = "hostess1", LastName = "hostess1" }, EmailAddress = "hostess1.hostess1@gmail.com", BirthDate = new DateTime(1995, 01, 01), EmployementDate = new DateTime(2020, 01, 01), Salary = 999 };
        public static Staff hostess2 = new Staff { FullName = new FullName { FirstName = "hostess2", LastName = "hostess2" }, EmailAddress = "hostess2.hostess2@gmail.com", BirthDate = new DateTime(1996, 01, 01), EmployementDate = new DateTime(2020, 01, 01), Salary = 999 };
        // Travellers
        public static Traveller traveller1 = new Traveller { FullName = new FullName { FirstName = "traveller1", LastName = "traveller1" }, EmailAddress = "traveller1.traveller1@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "no troubles", Nationality = "American" };
        public static Traveller traveller2 = new Traveller { FullName = new FullName { FirstName = "traveller2", LastName = "traveller2" }, EmailAddress = "traveller2.traveller2@gmail.com", BirthDate = new DateTime(1981, 01, 01), HealthInformation = "Some troubles", Nationality = "French" };
        public static Traveller traveller3 = new Traveller { FullName = new FullName { FirstName = "traveller3", LastName = "traveller3" }, EmailAddress = "traveller3.traveller3@gmail.com", BirthDate = new DateTime(1982, 01, 01), HealthInformation = "no troubles", Nationality = "Tunisian" };
        public static Traveller traveller4 = new Traveller { FullName = new FullName { FirstName = "traveller4", LastName = "traveller4" }, EmailAddress = "traveller4.traveller4@gmail.com", BirthDate = new DateTime(1983, 01, 01), HealthInformation = "Some troubles", Nationality = "American" };
        public static Traveller traveller5 = new Traveller { FullName = new FullName { FirstName = "traveller5", LastName = "traveller5" }, EmailAddress = "traveller5.traveller5@gmail.com", BirthDate = new DateTime(1984, 01, 01), HealthInformation = "Some troubles", Nationality = "Spanish" };
    }
}
