﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class Bot
    {
        [Key]
        public Guid Id { get; set; }


        public string Name { get; set; }


        public string Email { get; set; }

        public int Power { get; set; }

        public int Level{ get; set; }
    }
}
