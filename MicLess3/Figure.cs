﻿namespace MicLess3;

abstract class Figure
{
    public string name { get; set; }
    public string color { get; set; }
    public Figure(string name, string color)
    {
        this.name = name;
        this.color = color;
    }
}
