using natkSchedule.DTO;

namespace natkSchedule.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime startDate, DateTime endDate);
        Task<List<StudentGroupDto>> GetAllGroups();
    }
}