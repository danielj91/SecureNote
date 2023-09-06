using System.ComponentModel.DataAnnotations.Schema;

namespace SecureNote.Models;

public class Note
{
    public int Id { get; set; }
    [Column(TypeName = "varchar(200)")]
    public string Title { get; set; }
    public string Content { get; set; }
}