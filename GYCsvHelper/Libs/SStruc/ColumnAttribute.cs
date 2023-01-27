﻿namespace Libs.SStruc;

[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class ColumnAttribute : Attribute
{
    public string? Column { get; set; }
}