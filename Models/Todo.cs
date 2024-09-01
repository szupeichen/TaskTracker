namespace TaskTracker
{
  public class Todo
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public startTime DueDate { get; set; }
    public EndTime DueDate { get; set; }
    public Priority TaskPriority { get; set; }
    public bool Solved {get; set}
     
  }
}