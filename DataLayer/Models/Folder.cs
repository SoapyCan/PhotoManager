﻿using System;

namespace DataLayer
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
