using System;
using System.Collections.Generic;

namespace DatabaseFirstHW.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string? Username { get; set; }

    public string? Gender { get; set; }

    public DateTime? Birthday { get; set; }

    public int? RoleId { get; set; }

    public int? Points { get; set; }

    public int? DepartmentId { get; set; }
}
