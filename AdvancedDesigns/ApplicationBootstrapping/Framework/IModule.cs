using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBootstrapping.Framework
{
    internal interface ILoaderCore { }
    internal interface IModule<T, TPrevious> : ILoaderCore
    {
        Task<T> LoadAsync(TPrevious previousResult);
    }
}
