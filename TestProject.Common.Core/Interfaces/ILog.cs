﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Core.Interfaces
{
    public interface ILog
    {
        void Write(string log);

        string Read();

    }
}