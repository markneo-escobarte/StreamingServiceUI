using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamingServiceDL;

namespace StreamingServiceBL
{
    public class MovieBL
    {
        public bool VerifyUser(string Username, string Password)
        {
            MovieDL movieDL = new MovieDL();
            var result = movieDL.GetUser(Username);

            return result.Username != null ? true : false;
        }
    }
}
