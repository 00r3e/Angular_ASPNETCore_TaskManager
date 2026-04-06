using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using RepositoryContracts;

namespace Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskItem>> GetAllAsync(Guid userId)
        {
            return await _context.Tasks.Where(t => t.UserId == userId).ToListAsync();
        }

        public async Task<TaskItem?> GetByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<TaskItem> AddAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskItem?> UpdateAsync(int id, TaskItem task)
        {
            TaskItem? matchingTaskItem = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);

            if (matchingTaskItem == null)
            {
                return null;
            }

            matchingTaskItem.Title = task.Title;
            matchingTaskItem.Description = task.Description;
            matchingTaskItem.Status = task.Status;
            matchingTaskItem.DueDate = task.DueDate;
            matchingTaskItem.Priority = task.Priority;
            matchingTaskItem.Category = task.Category;
            matchingTaskItem.CreatedAt = task.CreatedAt;

            await _context.SaveChangesAsync();
            return matchingTaskItem;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
                return 0;
            }
            return -1;
        }
    }
}
