using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using ServiceContracts.DTOs.TaskDTOs;

namespace ServiceContracts
{
    public interface ITaskservice
    {
        Task<List<TaskResponse>> GetAllTasksAsync(Guid userId);
        Task<TaskResponse?> GetTaskAsync(int id);
        Task<TaskResponse> CreateTaskAsync(TaskAddRequest task, Guid userId);
        Task<TaskResponse?> UpdateTaskAsync(int id, TaskUpdateRequest task);
        Task<int> DeleteTaskAsync(int id);
    }
}

