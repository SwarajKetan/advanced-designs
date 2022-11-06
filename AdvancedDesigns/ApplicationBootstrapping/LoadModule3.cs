using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBootstrapping.Framework;

namespace ApplicationBootstrapping
{
    internal class LoadModule3 : IModule<Complex, string>
    {
        public Task<Complex> LoadAsync(string previousResult)
        {
            return Task.FromResult(new Complex()
            {
                Age = 100,
                Name = "Simpu"
            });
        }
    }
}
