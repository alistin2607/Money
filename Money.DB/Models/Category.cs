using System;

namespace Money.DB
{
    public class Category
    {
        public Guid ID { get; set; }
        public int Code  { get; set; }
        public string Name { get; set; }
    }
}