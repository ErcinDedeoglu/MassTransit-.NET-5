namespace POC.DTO
{
    public class AppSettingsDto
    {
        public QueueSettings QueueSettings { get; set; }
    }
    
    public class QueueSettings
    {
        public string Uri { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}