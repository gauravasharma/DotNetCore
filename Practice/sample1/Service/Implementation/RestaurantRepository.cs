using System.Collections.Generic;
using System.Linq;
using sample1.Model;
using sample1.Service.Interface;
namespace sample1.Service.Implementation
{ 
    public class RestaurantRepository : IRestaurantRepository
    {
      public  IEnumerable<Restaurant>GetAll(int ? Id)
      {
         var data= new List<Restaurant>
         {
            new Restaurant{Id=1, Name="Dawat"},
            new Restaurant{Id=2, Name="Chat Bhandar"},
            new Restaurant{Id=3, Name="Moti Mahal"}
         } as IEnumerable<Restaurant>;
         
         return Id==null ? data : data.Where(x=>x.Id==Id);
      }
    }

}