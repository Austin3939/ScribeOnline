﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Inscript_v5.Models
{
    public class InscriptionTextModel
    {
        
        public int TextID { get; set; }
        public int? InscriptionID { get; set; }
        public int? LineNumber { get; set; }
        public string Text { get; set; }


       
    }

   

}