﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTools.Configuration.FieldMap
{
   public class RegexFieldMapConfig : IFieldMapConfig
    {
        public string WorkItemTypeName { get; set; }
        public string sourceField { get; set; }
        public string targetField { get; set; }
        public string pattern { get; set; }
        public string replacement { get; set; }

        public string FieldMap
        {
            get
            {
                return "RegexFieldMap";
            }
        }
    }
}
