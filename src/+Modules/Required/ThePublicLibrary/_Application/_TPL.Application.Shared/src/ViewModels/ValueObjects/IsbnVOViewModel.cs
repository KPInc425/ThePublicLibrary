﻿namespace TPL.Application.Shared.ViewModels;
public class IsbnVOViewModel
{
    public string Isbn { get; set; }

    public override string ToString()
    {
        return Isbn;
    }
}
