﻿using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NatId { get; set; }
    }
}
