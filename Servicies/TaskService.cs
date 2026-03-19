using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using RepositoryContracts;
using ServiceContracts;
using ServiceContracts.DTOs.TaskDTOs;

namespace Servicies
{
    public class TaskService : ITaskservice
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TaskResponse>> GetAllTasksAsync()
        {
            var tasks = await _repository.GetAllAsync();
            return tasks.Select(t => t.ToTaskResponse()).ToList();
        }

        public async Task<TaskResponse?> GetTaskAsync(int id)
        {
            var task = await _repository.GetByIdAsync(id);
            
            return task == null ? null : task.ToTaskResponse();
        }

        public async Task<TaskResponse> CreateTaskAsync(TaskAddRequest taskAddRequest)
        {
            taskAddRequest.CreatedAt = DateTime.UtcNow;
            var task = await _repository.AddAsync(taskAddRequest.ToTaskItem());
            return task.ToTaskResponse();
        }

        public async Task<TaskResponse?> UpdateTaskAsync(int id, TaskUpdateRequest updateRequest)
        {
            var task = await _repository.UpdateAsync(id, updateRequest.ToTaskItem());

            return task == null ? null : task.ToTaskResponse();
        }

        public async Task<int> DeleteTaskAsync(int id)
        {
            var anwer = await _repository.DeleteAsync(id);

            return anwer == 0 ? 0 : -1;
        }
    }
}
