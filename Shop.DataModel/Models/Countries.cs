﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Shop.DataModel.Models
{
    public partial class Countries
    {
        public int Id { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreationDate { get; set; }
        public int? ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Name { get; set; }
    }
}