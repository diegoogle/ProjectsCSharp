﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class alumno
{
    public alumno()
    {
        this.alums_asigs = new HashSet<alum_asig>();
    }

    public int id_alumno { get; set; }
    public string nombre { get; set; }

    public virtual ICollection<alum_asig> alums_asigs { get; set; }
}

public partial class alum_asig
{
    public int id_alumno { get; set; }
    public int id_asignatura { get; set; }
    public float nota { get; set; }

    public virtual alumno alumno { get; set; }
    public virtual asignatura asignatura { get; set; }
}

public partial class asignatura
{
    public asignatura()
    {
        this.alums_asigs = new HashSet<alum_asig>();
    }

    public int id_asignatura { get; set; }
    public string nombre { get; set; }

    public virtual ICollection<alum_asig> alums_asigs { get; set; }
}