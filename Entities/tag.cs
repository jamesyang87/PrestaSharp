﻿using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PrestaSharp.Entities
{
    public class tag : PrestashopEntity
    {
        public int id { get; set; }
    }
}