﻿namespace Artsofte.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }

}
