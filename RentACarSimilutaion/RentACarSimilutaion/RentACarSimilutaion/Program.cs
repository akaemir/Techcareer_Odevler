﻿using RentACarSimilutaion.ConsoleUI;
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Service;

CarService carService = new CarService();
FuelService fuelService = new FuelService();
ColorService colorService = new ColorService();
//carService.GetById(1);
//carService.GetAll();
//carService.Add(3,1,1,1,"Rental",67896,2021,"34 BI8 41","BMW","i8 hybrid",12000);
//carService.Remove(4);
//carService.Update();
//carService.GetAllDetails();
//carService.GetAllDetailsByFuelId(5);
//carService.GetAllDetailsByColorId(1);
//carService.GetAllDetailsByPriceRange(10000,12000);
//carService.GetAllDetailsByBrandNameContains("renault");
//carService.GetAllDetailsByModelNameContains("clio");
//carService.GetAllDetailsByKilometerRange(20000, 60000);
//fuelService.GetAll();
//colorService.GetById(2);
carService.GetDetailById(21);