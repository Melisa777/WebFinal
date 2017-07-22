using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class DADirectorr
    {
        static public List<Director> ListadoDirector()
        {

            List<Director> alumno = new List<Director>();
            using (var data = new CineDBEntities())
            {
                return data.Director.ToList();
            }
        }
    }
}
