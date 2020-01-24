namespace ejemplo
{
    public class Miembro
    {
        public Seniority Seniority { get; set; }
        public virtual string ResolverTarea(string tarea)
        {
            return $"Tarea {tarea} resuelta";
        }
    }
}