using System;
using System.Collections.Generic;

namespace DatabaseFirstHW.Models;

public partial class Album
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? UserId { get; set; }

    public int? Rate { get; set; }
}
