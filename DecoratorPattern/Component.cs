﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Component
    {
        public abstract void Send(string message, List<string> recipients);
    }
}