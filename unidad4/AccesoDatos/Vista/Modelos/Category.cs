using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category(int categoryId, string categoryName, string description)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
        }

        /*public override string ToString()
        {
            return CategoryName;
        }*/
    }
}
