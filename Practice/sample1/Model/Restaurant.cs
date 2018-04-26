
using System.ComponentModel.DataAnnotations;

namespace  sample1.Model
{
    public class Restaurant
    {
       public int Id { get; set; }
       [Required,MaxLength(10)]
       public string Name { get; set; }

    }

}
