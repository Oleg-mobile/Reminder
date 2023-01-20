using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Storage
{
    public interface ITaskStorage
    {
        Task<IEnumerable<string>> GetAll();
    }
}
