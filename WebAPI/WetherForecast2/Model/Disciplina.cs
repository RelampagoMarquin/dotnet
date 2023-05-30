namespace WetherForecast2.Model
{
    public class Disciplina
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int CargaHoraria { get; set; }

        public int Semestre { get; set; }

        public Curso Curso { get; set; }
    }
}
