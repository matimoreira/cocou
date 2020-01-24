using System.Collections.Generic;

namespace ejemplo 
{
    public class Team
    {
        List<Miembro> miembros = new List<Miembro>();

        public Team()
        {
            // voy a agregar 3 miembros al equipo
            miembros.Add(new Miembro());
            miembros.Add(new Miembro());
            miembros.Add(new Miembro());
        }
    }
}