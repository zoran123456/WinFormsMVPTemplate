using System;
using System.Collections.Generic;

namespace WinFormsMVPTemplate.Infrastructure
{
    // Singleton and ServiceLocator patterns combined


    /// <summary>
    /// Class used to retrieve and add Services, for Dependency Injection
    /// </summary>
    public sealed class ServiceLocator
    {
        private static readonly ServiceLocator _instance = new ServiceLocator();
        private readonly IDictionary<object, object> services;

        private ServiceLocator()
        {
            services = new Dictionary<object, object>();
        }

        /// <summary>
        /// Get Instance of an ServiceLocator object
        /// </summary>
        public static ServiceLocator Instance
        {
            get
            {
                return _instance;
            }
        }


        public void AddService<T>(T implementation)
            where T : class
        {

            services.Add(typeof(T), implementation);

        }

        public T GetService<T>()
        {
            try
            {
                return (T)services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }

}
