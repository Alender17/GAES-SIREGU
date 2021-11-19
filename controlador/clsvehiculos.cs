using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAES_SIREGU.modelo;

namespace GAES_SIREGU.controlador
{
    public class clsvehiculos
    {
        public bool InsertarVehiculo(string matricula, int modelo, int motor, string imagen, string marca, DateTime soat, DateTime tecno)
        {
            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    var data = db.InsertarVehiculo(matricula, motor, modelo, imagen, marca, soat, tecno);

                    if (data > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EliminarVehiculo(string matricula)
        {
            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    var data = db.EliminarVehiculo(matricula);

                    if (data > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EditarVehiculo(string matricula, int modelo, int motor, string imagen, string marca, DateTime soat, DateTime tecno)
        {
            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    var data = db.EditarVehiculo(matricula, motor, modelo, imagen, marca, soat, tecno);

                    if (data > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IList<vehiculos> BuscarVehiculos()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                var datos = db.vehiculos.ToList();
                return datos;
            }
        }
    }
}
