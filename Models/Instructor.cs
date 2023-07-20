using System;
using System.Collections.Generic;

namespace NorthwindBlazorServer.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public string LastName { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual OfficeAssignment? OfficeAssignment { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
