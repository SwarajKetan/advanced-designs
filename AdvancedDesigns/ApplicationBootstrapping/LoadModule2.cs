using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class LoadModule2 : IModule<string, bool>
    {
        public Task<string> LoadAsync(bool previousResult)
        {
            if (!previousResult)
            {
                throw new Exception();
            }
            return Task.FromResult("loaded 2");
        }
    }
}
