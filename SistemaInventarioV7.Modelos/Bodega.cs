using System.ComponentModel.DataAnnotations;

namespace SistemaInventarioV7.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [MaxLength(60, ErrorMessage = "Nombre debe contener máximo 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripción es requerido")]
        [MaxLength(100, ErrorMessage = "Descripción debe contener máximo 100 caracteres")]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }
    }
}
