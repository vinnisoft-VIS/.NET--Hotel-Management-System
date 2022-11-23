using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewModel
{
    public class CheckListListModal
    {
        public List<CheckListModal> CheckListList { get; set; }

        public int Count { get; set; }

    }
    public class CheckListModal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AssignToUserId { get; set; }
        public int AssignByUserId { get; set; }
        public string AssignToUserName { get; set; }

        public string AssignByUserName { get; set; }
        public string Notes { get; set; }

        public string TaskDuration { get; set; }
        public int TemplateId { get; set; }
        public string Completed_flag { get; set; }
        public string Started_flag { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public string CreatedDate { get; set; }
    }
    public class SuccessCheckListMessage
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public CheckListModal CheckList { get; set; }

    }
    public class TemplateListModal
    {
        public List<TemplateModel> TemplateList { get; set; }

        public int Count { get; set; }

    }
    public class TemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedByName { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
    }

    public class AssignUserTemplates
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public string Class { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

    }
    public class SuccessTemplateMessage
    {
        public bool Status { get; set; }

    public string Message { get; set; }

    public TemplateModel Templates { get; set; }

}

    public class UserCheckListScheduleModal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public int CheckListId { get; set; }
        public string Username { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class SuccessUserCheckListScheduleMessage
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public UserCheckListScheduleModal UserCheckListSchedule { get; set; }

    }
}
