using ADSProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProyect.Repository
{
    public interface IGrupoRepository
    {
        List<GruposViewModel> obtenerGrupos();
        int agregarGrupo(GruposViewModel gruposViewModel);

        int actualizarGrupo(int idGrupo, GruposViewModel gruposViewModel);

        bool eliminarGrupo(int idGrupo);

        GruposViewModel obtenerGruposPorID(int idGrupo);
    }
}
