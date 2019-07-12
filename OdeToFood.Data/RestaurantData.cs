using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Id = 1,
                    Name = "Joel Curry",
                    Location = "Brighton",
                    Cuisine = CuisineType.Indian
                },
                new Restaurant()
                {
                    Id = 2,
                    Name = "Joel Pizza",
                    Location = "Brighton",
                    Cuisine = CuisineType.Italian
                },
                new Restaurant()
                {
                    Id = 3,
                    Name = "Joel Burritos",
                    Location = "Brighton",
                    Cuisine = CuisineType.Mexican
                },
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Name
                select r;
        }
    }
}
