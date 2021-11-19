using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAES_SIREGU.modelo;

namespace GAES_SIREGU.controlador
{
    class clsclientes
    {
        public IList<clientes> MostrarClientes()
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                return bd.clientes.ToList();
            }
        }

        //AGREGAR CLIENTES
        public void AgregarClientes(string nit, string nom, string dir, string tel, int id)
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                bd.SP_AddCliente(nit, nom, dir, tel, id);
            }
        }

        //ACTUALIZAR CLIENTES 
        public void UpdateClientes(string nit, string nom, string dir, string tel, int id)
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                bd.SP_UpdCliente(nit, nom, dir, tel, id);
            }
        }

        //ELIMINAR CLIENTES 
        public void deleteClientes(string nit)
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                bd.SP_RemCliente(nit);
            }
        }

        public IList<rutas> mostrarRutas()
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                return bd.rutas.ToList();
            }
        }
    }
}
