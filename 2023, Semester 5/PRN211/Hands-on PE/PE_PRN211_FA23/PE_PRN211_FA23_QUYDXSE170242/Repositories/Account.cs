using System;
using System.Collections.Generic;

namespace Repositories;

public partial class Account
{
    public int MemberAccountId { get; set; }

    public string MemberAccountPassword { get; set; } = null!;

    public string MemberFullName { get; set; } = null!;

    public string? MemberEmail { get; set; }

    public int? Role { get; set; }
}
