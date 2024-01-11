﻿using E_Commerce_Api.Domain.Common;
using E_Commerce_Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }
        public Category(int parentId, string name, int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }
        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priority { get; set; }
        public ICollection<Detail> Details{ get; set; }
    }
    public class Product : EntityBase
    {
        public Product()
        {

        }
       
        public required string Title { get; set; }
        public required string ImagePath { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }
        public required int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
