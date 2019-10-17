using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login1CodeFirst.Models
{
    public class ProfesionVista
    {
        public string NombreSesion { get; set; }
        public string Profesion { get; set; }

        LoginContext user = new LoginContext();

        Sesion obj = new Sesion();
        
        public bool singIn()
        {
            
            var query = from u in user.Sesion
                        where u.Profesion == Profesion
                        select u;

            if (query.Count() > 0)
            {
                return false;
            }
            else
            {
                obj.Profesion = Profesion;             

                user.Sesion.Add(obj);
                user.SaveChanges();

                return true;
            }
        }
    }
}