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
        public bool VerifyTitle(string Title)
        {
            MovieDL movieDL = new MovieDL();
            var result = movieDL.GetTitle(Title);

            return result.Title != null ? true : false;
        }

        public bool VerifyUser(string Username, string Password)
        {
            UserDL movieDL = new UserDL();
            var result1 = movieDL.GetUser(Username);

            return result1.Username != null ? true : false;
        }

        public bool UserProfile(string username, string password, string title)
        {
            SqlDbData dataService = new SqlDbData();
            var result2 = dataService.GetMovie();

            return result2 != null;
        }
    }
}
