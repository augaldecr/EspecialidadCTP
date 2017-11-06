namespace Entities
{
    public class Nota
    {
        public int? IdNota { get; set; }
        public int? Matricula { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
        public int? Asignatura { get; set; }
        public int? Curso_lectivo { get; set; }
        public int? Nivel { get; set; }
        public int? Periodo { get; set; }
        public string PeriodoNombre { get; set; }
        public decimal? Calificacion { get; set; }
        public int? Tipo { get; set; }
        public decimal? Vocacional { get; set; }
        public int? Esp1_id { get; set; }
        public string Esp1_nombre { get; set; }
        public decimal? Esp1_nota { get; set; }
        public int? Esp2_id { get; set; }
        public string Esp2_nombre { get; set; }
        public decimal? Esp2_nota { get; set; }
        public int? Esp3_id { get; set; }
        public string Esp3_nombre { get; set; }
        public decimal? Esp3_nota { get; set; }
    }
}
