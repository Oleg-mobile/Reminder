using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Storage
{
    public class StorageJson : ITaskStorage
    {
        public Task<IEnumerable<string>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
