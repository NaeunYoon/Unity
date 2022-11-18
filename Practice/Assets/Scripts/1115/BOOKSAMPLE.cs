using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Book
{
    decimal isbn13;
    public Book(decimal isbn13)   //»ý¼ºÀÚ
    {
        this.isbn13 = isbn13;
    }
}

public class EBOOK : Book
{
    public EBOOK(decimal isbn) : base(isbn)
    {

    }
    public EBOOK() : base(0)
    {
       
    }


}

public class BOOKSAMPLE : MonoBehaviour
{
    Book book = new Book(123);
    EBOOK Ebook = new EBOOK();
    void Start()
    {
        
    }



}
