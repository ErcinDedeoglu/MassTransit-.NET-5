using System;

namespace POC.DTO
{
    public class MessageDto
    {
        public Guid UniqueId { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }
}