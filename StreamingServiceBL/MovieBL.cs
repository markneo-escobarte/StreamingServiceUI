using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamingServiceDL;
using StreamingServiceModel;

namespace StreamingServiceBL
{
    public class MovieBL
    {
        private readonly SqlDbData _dataService; 
        
        public bool VerifyUser(string Username, string Password)
        {
            UserDL movieDL = new UserDL();
            var result1 = movieDL.GetUser(Username);

            return result1.Username != null ? true : false;
        }

         public MovieBL()
        {
            _dataService = new SqlDbData();
        }

        public List<User> GetTitle()
        {
            return _dataService.GetTitle();
        }

        public void AddTitle(string title)
        {
            _dataService.AddTitle(new User { Title = title });
        }

        public void DeleteTitle(string title)
        {
            _dataService.DeleteTitle(title);
        }

        public void UpdateTitle(string oldTitle, string newTitle)
        {
            _dataService.UpdateTitle(oldTitle, newTitle);

        }

    }
}
