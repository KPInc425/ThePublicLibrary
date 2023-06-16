﻿namespace TPL.Application.Automaps;
public class BookMapper : Profile
{
    public override string ProfileName
    {
        get { return "Book Map"; }
    }

    public BookMapper()
    {
        CreateMap<Book, BookViewModel>()
        ;
    }
}