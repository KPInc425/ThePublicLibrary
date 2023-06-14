﻿namespace TPL.Core.Entities;
public class BookCopy : BaseEntityTracked<Guid>
{
    public Book Book { get; } = null!;

    public int CopySequence { get; }
    public BookCondition Condition { get; private set; } = BookCondition.New;

    private BookCopy() { }
    public BookCopy(Book book, BookCondition condition = BookCondition.New)
    {
        Book = Guard.Against.Null(book);
        Condition = condition;

        CopySequence = book.BookCopies.Count() + 1;
    }
    public void SetCondition(BookCondition condition)
    {
        Condition = condition;
    }
}
