﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRepository
{
    internal interface IObserver
    {
        void Update(int balance);
    }
}
