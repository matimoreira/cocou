using System.Collections.Generic;

namespace ejemplo 
{
    public class Team
    {
        List<Miembro> miembros = new List<Miembro>();

        public Team()
        {
            miembros.Add(new Miembro());
            miembros.Add(new Miembro());
        }

    }
}