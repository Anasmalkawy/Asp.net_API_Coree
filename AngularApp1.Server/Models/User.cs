using System;
using System.Collections.Generic;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace AngularApp1.Server.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }
}

