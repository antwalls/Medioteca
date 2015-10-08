using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Medioteca.Models
{

    public class File
    {
        [Key]
        public string   file_ID { get; set; }
        public Byte[]   content;
        public string   file_Name { get; set; }
        public string   file_Path { get; set; }
        public FileType file_kind { get; set; }
        public string   contentType { get; set; }
    }
    public class UserFile
    {
        [Key]
        public int          Id     { get; set; }
        public string       User_Id   { get; set; }
        public string       file_ID   { get; set; }        
    }

    public class BookFile
    {
        [Key]
        public int Id { get; set; }
        public string Book_Id { get; set; }
        public string file_ID { get; set; }
    }

    public class SongFile
    {
        [Key]
        public int Id { get; set; }
        public string Song_Id { get; set; }
        public string file_ID { get; set; }
    }

    public class MovieFile
    {
        [Key]
        public int Id { get; set; }
        public string Song_Id { get; set; }
        public string file_ID { get; set; }
    }
}