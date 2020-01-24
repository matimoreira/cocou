namespace ejemplo
{
    public class MiembroCrack : Miembro
    {
        public override string ResolverTarea(string tarea)
        {
            return $"{tarea} resuelta magistralmente por mí";
        }

        public string ResolverCosasQueNadieMasPuede()
        {
            return "lo logré";
        }

    }

}