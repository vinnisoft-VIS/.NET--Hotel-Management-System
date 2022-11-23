using DataViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserData
{
   public interface IUserDataService
    {
        string happyreturn();
        List<SecurityQuestionModel> GetSecurityQuestion();
        SuccessUserMessage InsertSecurityQuestionResponse(SecurityQuestionResponseModel obj);
    }
}
