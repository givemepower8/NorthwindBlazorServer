﻿using System;
using System.Collections.Generic;

namespace NorthwindBlazorServer.Models;

public partial class OfficeAssignment
{
    public int InstructorId { get; set; }

    public string? Location { get; set; }

    public virtual Instructor Instructor { get; set; } = null!;
}
