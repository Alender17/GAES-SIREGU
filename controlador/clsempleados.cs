using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAES_SIREGU.modelo;

namespace GAES_SIREGU.controlador
{
    public class clsempleados
    {
        public IList<camioneros> Mostrar()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                return db.camioneros.ToList();
            }
        }

        public void AgregarEmpleados(int cedula, string nombre, string direccion, string imagen, string correo, string telefono,
                                      string tipo_s, int id_tipoem, string matricula, int estado)
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                db.sp_addempleado(cedula, nombre, direccion, imagen, correo, telefono, tipo_s, id_tipoem, matricula, estado);
            }
        }

        public void EditarEmpleados(int cedula, string nombre, string direccion, string imagen, string correo, string telefono,
                                      string tipo_s, int id_tipoem, string matricula, int estado)
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                db.sp_editarempleado(cedula, nombre, direccion, imagen, correo, telefono, tipo_s, id_tipoem, matricula, estado);
            }
        }

        public void eliminarEmleado(int cedula)
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                db.sp_deleteempleados(cedula);
            }
        }

        public IList<tipoEmpleado> tipoEmpleado()
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                return bd.tipoEmpleado.ToList();
            }
        }

        public IList<vehiculos> vehiculos()
        {
            using (DBSIGERUEntities1 bd = new DBSIGERUEntities1())
            {
                return bd.vehiculos.ToList();
            }
        }
    }
}
