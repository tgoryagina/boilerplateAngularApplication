using Abp.Application.Services.Dto;

namespace SimpleInvoiceSystem.Tasks.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}