using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAES_SIREGU.modelo;

namespace GAES_SIREGU.controlador
{
    public class clsentregas
    {
        public IList<rutas> BuscarRutas()
        {
            using(DBSIGERUEntities1 db  = new DBSIGERUEntities1())
            {
                return db.rutas.ToList();
            }
        }
        public IList<vehiculos> BuscarVehiculos()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                return db.vehiculos.ToList();
            }
        }
        public IList<camioneros> BuscarVendedor()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {   
                return db.camioneros.Where(x => x.id_tipoempleado ==2).OrderBy(x=>x.nombre).ToList();
            }
        }
        public IList<camioneros> BuscarAuxiliar()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                return db.camioneros.Where(x => x.id_tipoempleado == 1).OrderBy(x => x.nombre).ToList();
            }
        }

        public bool InsertarEntrega(DateTime fecha, int id_ruta,int kilometraje, string matricula, int cedula_auxiliar,int cedula_vendedor)
        {
            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    var r = db.InsertarEntrega(fecha, id_ruta, kilometraje, matricula, cedula_auxiliar, cedula_vendedor);

                    if (r > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
