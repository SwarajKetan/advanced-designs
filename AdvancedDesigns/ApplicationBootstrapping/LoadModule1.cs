using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class LoadModule1 : IModule<bool, string>
    {
        public Task<bool> LoadAsync(string previousResult)
        {
            return Task.FromResult(true);
        }
    }
}
