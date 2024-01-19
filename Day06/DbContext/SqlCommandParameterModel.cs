﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.DbContext
{
    public class SqlCommandParameterModel
    {
        public string ParameterName { get; set; }
        public DbType DataType { get; set; }
        public dynamic Value { get; set; }
    }
}
