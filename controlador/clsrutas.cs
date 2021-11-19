using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAES_SIREGU.modelo;

namespace GAES_SIREGU.controlador
{
    public class clsrutas
    {
        public List<rutas> ConsultarRutas()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                return db.rutas.ToList();
            }
        }
        public bool InsertarRuta(string descripcion, int kiloemtraje)
        {
            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    var data = db.InsertarRuta(descripcion, kiloemtraje);

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
    }
}
