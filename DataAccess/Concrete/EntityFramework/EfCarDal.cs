using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        private readonly Random _random = new Random();
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = (from p in filter == null ? context.Cars : context.Cars.Where(filter)
                    join c in context.Colors on p.ColorId equals c.ColorId
                    join d in context.Brands on p.BrandId equals d.BrandId
                    join im in context.CarImages on p.Id equals im.CarId
                    select new CarDetailDto
                    {
                        BrandId = d.BrandId,
                        BrandName = d.BrandName,
                        ModelName = p.ModelName,
                        ColorId = c.ColorId,
                        ColorName = c.ColorName,
                        DailyPrice = p.DailyPrice,
                        Description = p.Description,
                        ModelYear = p.ModelYear,
                        Id = p.Id,
                        FindeksScore = _random.Next(1, 1900),
                        Date = im.Date,
                        ImagePath = im.ImagePath,
                        ImageId = im.Id
                        }).ToList();
                return result.GroupBy(p => p.Id).Select(p => p.FirstOrDefault()).ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailById(int carId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                
                var result = from p in context.Cars 
                    join c in context.Colors on p.ColorId equals c.ColorId
                    join d in context.Brands on p.BrandId equals d.BrandId
                    join im in context.CarImages on p.Id equals im.CarId
                             where p.Id == carId
                    select new CarDetailDto
                    {
                        BrandId = d.BrandId,
                        BrandName = d.BrandName,
                        ColorId = c.ColorId,
                        ModelName = p.ModelName,
                        ColorName = c.ColorName,
                        DailyPrice = p.DailyPrice,
                        Description = p.Description,
                        ModelYear = p.ModelYear,
                        Id = p.Id,
                        FindeksScore = _random.Next(1,1900),
                        Date = im.Date,
                        ImagePath = im.ImagePath,
                        ImageId = im.Id
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandAndColor(int brandId, int colorId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars.Where
                        (car => car.BrandId == brandId && car.ColorId == colorId)
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join color in context.Colors on car.ColorId equals color.ColorId

                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        ModelName = car.ModelName,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear,
                        ImagePath = (from carImage in context.CarImages
                            where (carImage.CarId == car.Id)
                            select carImage).FirstOrDefault().ImagePath
                    };
                return result.ToList();
            }
        }

        public int TotalCars()
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Cars.Count();
            }
        }

        public CarDetailDto LastRentedCar()
        {
            //En Son Kiralanan Araba
            using (ReCapContext context = new ReCapContext())
            {
                var result =
                    (from r in context.Rentals
                        join c in context.Cars on r.CarId equals c.Id
                        join cu in context.Customers on r.CustomerId equals cu.Id
                        join b in context.Brands on c.BrandId equals b.BrandId
                        join u in context.Users on cu.UserId equals u.Id
                        join co in context.Colors on c.ColorId equals co.ColorId
                        join im in context.CarImages on c.Id equals im.CarId
                        orderby r.Id descending 
                        select new CarDetailDto
                        {
                            BrandId = b.BrandId,
                            BrandName = b.BrandName,
                            ColorId = co.ColorId,
                            ColorName = co.ColorName,
                            ModelName = c.ModelName,
                            DailyPrice = c.DailyPrice,
                            Description = c.Description,
                            ModelYear = c.ModelYear,
                            Id = c.Id,
                            FindeksScore = _random.Next(1, 1900),
                            Date = im.Date,
                            ImagePath = im.ImagePath,
                            ImageId = im.Id
                        }).FirstOrDefault();
                return result;
            }
        }
        
    }
}
