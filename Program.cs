﻿using ServiceMtk_P2_096;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfigMtk_P2_096
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                Console.WriteLine("Server is Ready!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
