﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// <summary>
/// Descripción breve de ContextoTutorias
/// </summary>
public class ContextoTutorias : DbContext
{
  public DbSet<profesor> profesores { get; set; }
}
