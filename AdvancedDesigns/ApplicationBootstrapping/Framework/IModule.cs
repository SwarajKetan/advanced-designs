using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBootstrapping.Framework
{
    /// <summary>
    /// Internal to fw.
    /// </summary>
    internal interface ILoaderCore { }

    /// <summary>
    /// Every module must implement <see cref="IModule{TResult, TResultPrevious}"/>.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TResultPrevious"></typeparam>
    internal interface IModule<TResult, TResultPrevious> : ILoaderCore
    {
        Task<TResult> LoadAsync(TResultPrevious previousResult);
    }
}
