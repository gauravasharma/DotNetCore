using System.Collections.Generic;
using sample2.Models;
namespace sample2.Services.Interface
{
    public interface IDataElementRepository
    {
        IEnumerable<DataElement> GetAll();
        DataElement Get(int id);
        DataElement Add(DataElement dataElement);
    }
}
