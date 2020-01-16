namespace SincerApi.Models
{
  public class TaskItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public bool IsRepeat { get; set; }
        public bool PushNotif { get; set; }
        public long LastTimestamp { get; set; }
    }
}