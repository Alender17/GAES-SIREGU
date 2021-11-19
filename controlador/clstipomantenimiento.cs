using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAES_SIREGU.modelo;
namespace GAES_SIREGU.controlador
{
    public class clstipomantenimiento
    {
        public void addtm(string descrip)
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                db.sp_add_tipomantenimiento(descrip);
            }
        }

        //public void deletetm(int id)
        //{
        //    using (DBSIGERUEntities db = new DBSIGERUEntities())
        //    {
        //            db.sp_eiminartm(id);
        //    }
        //}

        public IList<tipoMantenimiento> mostrartiposm()
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                    return db.tipoMantenimiento.ToList();
            }
        }

        public void updatetm(int id,string descrip)
        {
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                    db.SP_Upd_tipomantenimiento(descrip, id);
            }
        }

    }
}
