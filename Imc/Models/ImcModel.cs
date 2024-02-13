using System.ComponentModel.DataAnnotations;

namespace Imc.Models
{
    public class ImcModel
    {
        public double? AlturaEmMetros { get; set; }
        public double? Peso { get; set; }
        public char Sexo { get; set; } = 'F';
        public bool MaiorDe65 { get; set; }
    }
}
