using System;
using System.Collections.Generic;

namespace SingletonExample
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private readonly List<string> _servers = new List<string>();
        private readonly Random _random = new Random();

        // Lock synchronization object
        private static readonly object syncLock = new object();

        protected LoadBalancer()
        {
            this._servers.Add("ServerI");
            this._servers.Add("ServerII");
            this._servers.Add("ServerIII");
            this._servers.Add("ServerIV");
            this._servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked

            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        public string GetServer()
        {
            int r = this._random.Next(this._servers.Count);
            return this._servers[r].ToString();
        }
    }
}
