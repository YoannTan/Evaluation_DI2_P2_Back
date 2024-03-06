namespace EvaluationBackEnd.Data.Entities;

public class Event
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public DateTime Date { get; set; }
    
    public DateTime Time { get; set; }
    
    public string Location { get; set; }
}