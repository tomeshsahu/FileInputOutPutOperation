﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class BinarySerialization
        {
            public void Serialization()
            {
                Demo sample = new Demo();
                FileStream fileStream = new FileStream(@"E:\FileOiDemo\SerializationDemo\Example1.txt", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, sample);
                Console.ReadKey();
            }
        }

        [Serializable]
        public class Demo
        {
            public string ApplicationName { get; set; } = "Binary Serialize";
            public int ApplicationId { get; set; } = 1001;
        }


    }

