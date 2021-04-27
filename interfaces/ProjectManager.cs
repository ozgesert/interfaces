using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Remove(IPersonManager personManager)
        {
            personManager.Remove();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
