using System.ComponentModel.DataAnnotations;

namespace film_api.Models;

public class Film {
  public int Id { get; set; }
  [Required(ErrorMessage = "O título do filme é obrigatório")]
  public string Title { get; set; }
  [Required(ErrorMessage = "O genero do filme é obrigatório")]
  [MaxLength(50, ErrorMessage = "O tamanho do genero não pode exceder 50 caracteres")]
  public string Genere { get; set; }
  [Required]
  [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
  public int Duraction { get; set; }
}
