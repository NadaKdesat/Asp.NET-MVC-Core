using System;
using System.Collections.Generic;

namespace Task_52.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Manager { get; set; }
}
