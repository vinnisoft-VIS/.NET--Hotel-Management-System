using DataViewModel;
using Repository.UserDataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserData
{
    public class UserDataService : IUserDataService
    {
        IUserRepository _userservice;

        public UserDataService(IUserRepository userservice)
        {
            _userservice = userservice;
        }

        public string happyreturn()
        {
           return  _userservice.happyreturn();
        }
        public List<SecurityQuestionModel> GetSecurityQuestion()
        {
            return _userservice.GetSecurityQuestion();
        }
        public SuccessUserMessage InsertSecurityQuestionResponse(SecurityQuestionResponseModel obj)
        {
            return _userservice.InsertSecurityQuestionResponse(obj);
        }
    }
}
