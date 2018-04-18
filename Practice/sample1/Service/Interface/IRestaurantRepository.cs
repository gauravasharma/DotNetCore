using System.Collections.Generic;
using sample1.Model;
namespace sample1.Service.Interface
{
    public interface IRestaurantRepository
    {
       IEnumerable<Restaurant>GetAll(int ? id);
    }

}
