﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anchor
{
    [Serializable]
    public class Settings
    {

        public string WampServerPath { get; set; }

        public bool Enabled { get; set; }

    }
}
