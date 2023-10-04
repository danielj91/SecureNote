using System.ComponentModel.DataAnnotations.Schema;

namespace SecureNote.Models;

public class Note
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Column(TypeName = "varchar(300)")]
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}