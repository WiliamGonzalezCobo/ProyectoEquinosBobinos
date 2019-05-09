using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace BLL
{
    public class Animal
    {
        public void ClasificarAnimal(string ruta)
        {
            Utils objUtils = new Utils();
            List<Entidades.Animal> lBobinos = new List<Entidades.Animal>();
            List<Entidades.Animal> lEquinos = new List<Entidades.Animal>();

            try
            {
                foreach (var item in objUtils.ReadFileAnimales("C:\\EQUNOSBOVINOS.DAT"))
                {
                    if (item.propNombre.ToUpper().Contains("B"))
                    {
                        lBobinos.Add(item);
                    }
                    else
                    {
                        lEquinos.Add(item);
                    }
                }

                objUtils.GenerarArchivo(lBobinos, "C:\\Bobinos.txt");
                objUtils.GenerarArchivo(lEquinos, "C:\\Equinos.txt");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
