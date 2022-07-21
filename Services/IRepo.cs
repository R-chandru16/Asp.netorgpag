using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_student.Services
{
    public interface IRepo<k>
    {
        k Add(k k);
        k Update(k k);
        ICollection<k> GetAll();
        k Get(int id);
        k Delete(int id);
       
    }
}
