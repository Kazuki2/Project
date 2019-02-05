
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace フォームデザイン1
{
    [Serializable]
    static class DataBase
    {
        private static List<Book> _books = new List<Book>();
        private static List<Member> _members = new List<Member>();

        /// <summary>
        /// Bookの追加、Bookインスタンスを引数とします。
        /// </summary>
        /// <param name="book">Bookオブジェクト</param>
        /// <returns>成功可否:bool</returns>
        public static bool AddBook(Book book)
        {
            if (GetBookByIsbn(book.Isbn) != null) return false;
            _books.Add(book);
            return true;
        }

        /// <summary>
        /// Memberの追加、Memberインスタンスを引数とします
        /// </summary>
        /// <param name="member">Memberインスタンス</param>
        /// <returns>成功可否:bool</returns>
        public static bool AddMember(Member member)
        {
            if (GetMemberByNumber(member.Number) == null)
            {
                _members.Add(member);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 会員を会員番号から取得します。
        /// 無ければnullで帰ります。
        /// </summary>
        /// <param name="number">会員番号</param>
        /// <returns>会員</returns>
        public static Member GetMemberByNumber(int number)
        {
            foreach (var member in _members)
            {
                if (member.Number == number)
                    return member;
            }
            return null;
        }

        /// <summary>
        /// タイトルからBookのリストを取得します
        /// 無ければカラリストが帰ります。
        /// </summary>
        /// <param name="title">本のタイトル(部分一致)</param>
        /// <returns>Bookリスト</returns>
        public static List<Book> GetBooksByTitle(string title)
        {
            var result = new List<Book>();
            foreach (var book in _books)
            {
                if(book.Title.IndexOf(title, StringComparison.Ordinal)!=-1)
                    result.Add(book);
            }
            return result;
        }

        /// <summary>
        /// ISBNコードからBookインスタンスを取得します
        /// 無ければnullで帰ります。
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public static Book GetBookByIsbn(int isbn)
        {
            foreach (var book in _books)
            {
                if (book.Isbn == isbn)
                    return book;
            }
            return null;
        }

        /// <summary>
        /// デバッグ用です。気にしないでください
        /// </summary>
        /// <returns>JSONなBooks</returns>
        public static string BooksToString()
        {
            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms)) {
                var serializer = new DataContractJsonSerializer(typeof(List<Book>));
                serializer.WriteObject(ms, _books);
                ms.Position = 0;

                var json = sr.ReadToEnd();

                return json;
            }
        }

        /// <summary>
        /// データベースを保存します
        /// </summary>
        public static void Save()
        {
            FileStream fs = new FileStream("./Books.bin",FileMode.Create,FileAccess.Write);
            var bf = new BinaryFormatter();
            bf.Serialize(fs,_books);
            fs.Close();
            fs = new FileStream("./Members.bin",FileMode.Create,FileAccess.Write);
            bf.Serialize(fs,_members);
            fs.Close();
        }

        /// <summary>
        /// データベースを読み込みます
        /// </summary>
        public static void Load()
        {
            FileStream fs = new FileStream("./Books.bin",FileMode.Open,FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            object obj = f.Deserialize(fs);
            _books = (List<Book>)obj;
            fs.Close();fs = new FileStream("./Members.bin",FileMode.Open,FileAccess.Read);
            obj = f.Deserialize(fs);
            _members = (List<Member>)obj;
            fs.Close();
        }
    }

    [Serializable]
    class Book
    {
        /// <summary>
        /// 本です。newするとBookインスタンスが生成されます。
        /// </summary>
        public Book()
        {

        }
        /// <summary>
        /// 本のISBNコードを参照します。設定もできます。
        /// </summary>
        public int Isbn { get; set; }
        /// <summary>
        /// 本のタイトルを参照します。設定もできます。
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 本の著者を参照します。設定もできます。
        /// </summary>
        public string Actor { get; set; }
        /// <summary>
        /// 本の発行会社を参照します。設定もできます。
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 本の発行日を参照します。設定もできます。DateTime型です。
        /// </summary>
        public DateTime IssueDate { get; set; }
    }

    [Serializable]
    class Member
    {
        /// <summary>
        /// 会員です。newするとMemberインスタンスが生成されます
        /// </summary>
        public Member()
        {

        }
        /// <summary>
        /// 会員番号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 住所
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// メールアドレス
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 誕生日、DateTime型です。
        /// </summary>
        public DateTime BarthDay { get; set; }
    }
}
