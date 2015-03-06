using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // importado

namespace ConexionBD_con_Interface
{
    interface Idata
    {
        DataSet Listar();
        DataSet listarporCodigo(int codigo);
        DataSet listarporNombre(string Nombre);
    }
}
