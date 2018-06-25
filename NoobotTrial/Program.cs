﻿using System;
using System.IO;
using Noobot.Core.Configuration;
using NoobotTrial.Configuration;

namespace NoobotTrial
{
    class Program
    {
        static void Main()
        {
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configuration/config.json");
            var jsonConfigReader = new JsonConfigReader(configPath);
            var middleWareConfiguration = new NoobotTrialConfiguration();

            var noobotCore = Bootstrapper.SetupNoobotCore(jsonConfigReader, middleWareConfiguration);

            var noobotHost = new NoobotHost(noobotCore);

            noobotHost.Start();

            Console.Read();
        }
    }
}
