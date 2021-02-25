using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByModelYear(decimal min,decimal max);
        List<Car> GetCarsByBrandId(int _brandId);
        List<Car> GetCarsByColorId(int _colorId);
        List<CarDetailDto> GetCarDetail();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
