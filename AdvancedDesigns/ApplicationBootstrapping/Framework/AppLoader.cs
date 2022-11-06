using System.Diagnostics;

namespace ApplicationBootstrapping.Framework
{
    internal class AppLoader
    {
        private readonly List<dynamic> Modules = new List<dynamic>();

        public AppLoader Register(object module)
        {
            if (module is not ILoaderCore)
                throw new ArgumentException();

            Modules.Add(module);
            return this;
        }

        /// <summary>
        /// Returns 'true' if all modules are loaded successfully.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> RunAsync()
        {
            try
            {
                dynamic? result = null;

                for (int i = 0; i < Modules.Count; i++)
                {
                    var module = Modules[i];

                    // you can compute the load time of each module and optimize.
                    result = await module.LoadAsync(result);
                }

                return true;
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ex}");
                return false;
            }
            finally
            {
                Modules.Clear();
            }
        }
    }
}
