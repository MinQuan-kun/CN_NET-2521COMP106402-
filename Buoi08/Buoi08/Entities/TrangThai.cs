using System;
using System.Collections.Generic;

namespace Buoi08.Entities;

public partial class TrangThai
{
    public int MaTrangThai { get; set; }

    public string TenTrangThai { get; set; } = null!;

    public string? MoTa { get; set; }
}
