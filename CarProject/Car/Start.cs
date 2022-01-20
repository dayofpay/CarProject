using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Car
{
    class Start
    {
        public static string carState
        {
            get;set;
        }
        public static void startCar()
        {
            if(Modules.CarFuel.fuelLevel > 2.5) // Проверява стойноста на резервоара
            {
                try
                {
                    // Проверка за критични грешки
                    Console.WriteLine("Нивото на горивото е над минималната стойност ....");
                    if(Errors.Error.errors.Contains("Gearbox Failure(0x01)")) // Проблем със Park Позицията
                    {
                        MMI.Display.addInfo("Проблем със скоростната кутия тип \r\n 0x01 ( P Position Failure )");
                    }
                    if (Errors.Error.errors.Contains("Gearbox Failure(0x02)")) // Проблем със Neutral Позицията
                    {
                        MMI.Display.addInfo("Проблем със скоростната кутия тип \r\n 0x02 ( N Position Failure )");
                    }
                    if (Errors.Error.errors.Contains("Gearbox Failure(0x03)")) // Проблем със Drive Позицията
                    {
                        MMI.Display.addInfo("Проблем със скоростната кутия тип \r\n 0x03 ( D Position Failure )");
                    }
                    if (Errors.Error.errors.Contains("Gearbox Failure(0x04)")) // Проблем със Sport Позицията
                    {
                        MMI.Display.addInfo("Проблем със скоростната кутия тип \r\n 0x04 ( S Position Failure )");
                    }
                    if (Errors.Error.errors.Contains("Oil Sensor(xx*2)")) // Сензора за моторното масло е в неизправност
                    {
                        MMI.Display.addInfo("Проблем със сензора за маслото \r\n xx*2 (  )");
                    }
                    if (Errors.Error.errors.Contains("FuelSettings(P0001)")) // Регулатор за количество гориво – неизправна или прекъсната верига
                    {
                        MMI.Display.addInfo("Проблем със регулатора за количество гориво – неизправна или прекъсната верига \r\n P0001 (  )");
                    }
                    if (Errors.Error.errors.Contains("EngineValve(P0014)")) // Проверка на позицията на разпределителен вал 1
                    {
                        MMI.Display.addInfo("Проблем със позицията на  разпределителен вал 1 – твърде малък аванс (на изпускателни клапани, десен или заден вал, на първи ред (блок) цилиндри) \r\n P0001 (  )");
                    }
                    if (Errors.Error.errors.Contains("eValve(P0086)")) // Проверка на Соленоиден (електрически) клапан за управление на изпускателните клапани
                    {
                        MMI.Display.addInfo("Проблем със позицията на електрическия клапан за управление на изпускателните клапани (втори ред цилиндри) – напрежение над допустимата стойност \r\n P0086 (  )");
                    }
                }
                catch(InvalidProgramException softwareError)
                {
                    Console.WriteLine($"Софтуерна грешка ... {softwareError.Message}");
                }
            }
            else // Активира се ако нивото на горивото е под 2.5 литра
            {
                Console.WriteLine($"Нивото на горвито е под минималната стойност.. Уверете се, че автомобила има налични минимум 2.5 Литра {Modules.CarInfo.fuelType} ! ");
            }
        }
        public static void StopCar()
        {
            if (carState == "ON")
            {
                if (Gearbox.currentStickPosition == "P")
                {
                    Car.Stop.isStopped(true);
                }
                else
                {
                    Console.WriteLine("Please, switch the gear position to Park");
                }
            }
            else
            {
                Console.WriteLine("Car is already off ...");
            }
        }
    }
}
