using System;
namespace Plane.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Wingspan { get; set; }

        public Plane()
        {
        }
    }
}
