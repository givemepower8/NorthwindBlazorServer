using System;
using System.Collections.Generic;

namespace NorthwindBlazorServer.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public decimal Budget { get; set; }

    public int? InstructorId { get; set; }

    public string? Name { get; set; }

    public byte[]? RowVersion { get; set; }

    public DateTime StartDate { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual Instructor? Instructor { get; set; }
}
