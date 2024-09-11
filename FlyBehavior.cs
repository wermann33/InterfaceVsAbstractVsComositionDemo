﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVSAbstVCompDemo
{
    public class FlyBehavior : IMovementBehavior
    {
        public void Move(string name)
        {
            Console.WriteLine(name + " is flying!");
        }
    }
}
