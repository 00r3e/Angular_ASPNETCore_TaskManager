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
        Task<List<TaskResponse>> GetAllTasksAsync();
        Task<TaskResponse?> GetTaskAsync(int id);
        Task<TaskResponse> CreateTaskAsync(TaskAddRequest task);
        Task<TaskResponse?> UpdateTaskAsync(int id, TaskUpdateRequest task);
        Task<int> DeleteTaskAsync(int id);
    }
}

