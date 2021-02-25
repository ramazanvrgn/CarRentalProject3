using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car { Id = 1, ModelYear = 2018, DailyPrice = 400, 
                Description = "A5 Cabrio", BrandId = 1, ColorId = 1002 };
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //-----------------------ColorManager CRUD Testleri--------------------------------
            //colorManager.Delete(new Color { Id = 2002, ColorName = "Orange" });
            //colorManager.Update(new Color { Id=2,ColorName="Orange"});
            //colorManager.Add(new Color { ColorName="Lila"});
            //ColorGetByIdTest(colorManager);
            //ColorGetAllTest(colorManager);

            //-----------------------BrandManager CRUD Testleri--------------------------------
            //brandManager.Update(new Brand {Id=1005,BrandName="Opel" });
            //brandManager.Delete(new Brand { Id = 1004 });
            //brandManager.Add(new Brand { BrandName = "Volkswagen" });
            //BrandGetByIdTest(brandManager);
            // BrandGetAll(brandManager);

            //-----------------------CarManager CRUD Testleri--------------------------------
            //carManager.Update(car1);
            //carManager.Delete(car1);
            //carManager.Add(car1);
            //ColorIdFilterTest(carManager);
            //BrandIdFilterTest(carManager);
            //ModelYearFilterTest(carManager);
            //CarDetailTest(carManager);
            //CarGetAllTest();
        }

        private static void ColorGetByIdTest(ColorManager colorManager)
        {
            foreach (var r in colorManager.GetById(4))
            {
                Console.WriteLine(r.ColorName);
            }
        }

        private static void ColorGetAllTest(ColorManager colorManager)
        {
            foreach (var r in colorManager.GetAll())
            {
                Console.WriteLine(r.ColorName);
            }
        }

        private static void BrandGetByIdTest(BrandManager brandManager)
        {
            foreach (var b in brandManager.GetById(1))
            {
                Console.WriteLine(b.BrandName);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine(b.BrandName);
            }
        }

        private static void ColorIdFilterTest(CarManager carManager)
        {
            foreach (var c in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void BrandIdFilterTest(CarManager carManager)
        {
            foreach (var c in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(c.Description);
            }
        }

        private static void ModelYearFilterTest(CarManager carManager)
        {
            foreach (var c in carManager.GetByModelYear(2010, 2016))
            {
                Console.WriteLine(c.ModelYear);
            }
        }

        private static void CarDetailTest(CarManager carManager)
        {
            foreach (var c in carManager.GetCarDetail())
            {
                Console.WriteLine(c.BrandName + " " + c.Description
                    + " " + c.ModelYear + " " + c.ColorName
                    + " " + c.DailyPrice);
            }
        }

        private static void CarGetAllTest()
        {

            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var c in carManager1.GetAll())
            {
                Console.WriteLine(c.Description);
            }
        }
    }
}
