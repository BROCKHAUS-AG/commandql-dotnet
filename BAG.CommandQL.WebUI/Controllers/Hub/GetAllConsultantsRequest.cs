﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BAG.CommandQL.WebUI.Controllers.Hub
{
    public class GetConsultantsRequest
    {
        public string Mandant { get; set; }
        public string Group { get; set; }
    }
}