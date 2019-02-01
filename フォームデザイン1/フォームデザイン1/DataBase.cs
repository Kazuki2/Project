using System;
using System.Collections.Generic;

namespace フォームデザイン1
{
    [Serializable]
    class DataBase
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly List<Member> _members = new List<Member>();
        DataBase()
        {
        }

        public bool AddBook(Book book)
        {
            if (GetBookByIsbn(book.Isbn) != null) return false;
            _books.Add(book);
            return true;
        }

        public bool AddMember(Member member)
        {
            if (GetMemberByNumber(member.Number) == null)
            {
                _members.Add(member);
                return true;
            }
            return false;
        }

        public Member GetMemberByNumber(int number)
        {
            foreach (var member in _members)
            {
                if (member.Number == number)
                    return member;
            }
            return null;
        }

        public List<Book> GetBooksByTitle(string title)
        {
            var result = new List<Book>();
            foreach (var book in _books)
            {
                if(book.Title.IndexOf(title, StringComparison.Ordinal)!=-1)
                    result.Add(book);
            }
            return result;
        }

        public Book GetBookByIsbn(int isbn)
        {
            foreach (var book in _books)
            {
                if (book.Isbn == isbn)
                    return book;
            }
            return null;
        }
    }

    class Book
    {
        Book()
        {

        }
        public int Isbn { get; set; }
        public string Title { get; set; }
        public string Actor { get; set; }
        public string Company { get; set; }
        public DateTime IssueDate { get; set; }
    }

    class Member
    {
        Member()
        {

        }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime BarthDay { get; set; }
    }
}
