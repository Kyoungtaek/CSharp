﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_DataInput.Model
{
    public class Passport
    {
        public string PassportNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
        public byte[] Picture { get; set; }
    }
}
