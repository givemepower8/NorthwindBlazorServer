using System;
using System.Collections.Generic;

namespace NorthwindBlazorServer.Models;

public partial class Student
{
    public int Id { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
