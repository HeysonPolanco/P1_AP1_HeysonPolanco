using System.ComponentModel.DataAnnotations;

namespace Register.Models;

public class Entradas_Guacales

{
	[Key]

	public int Id { get; set; }

	[Required(ErrorMessage = "This is Requiered")]

	public string Context { get; set; } = null!;

}
