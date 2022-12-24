using System;
using System.Collections.Generic;

namespace TCrud.Models;

public partial class Costumer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Age { get; set; }

    public DateTime BorthDate { get; set; }
}
