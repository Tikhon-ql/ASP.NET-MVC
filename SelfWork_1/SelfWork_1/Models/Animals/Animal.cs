using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SelfWork_1.Models.Animals
{
    public class Animal
    {
        public int Id { get; set; }
        public byte[] AnimalImage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Video> Videos { get; set; }
    }
}