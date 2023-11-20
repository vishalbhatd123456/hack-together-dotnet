public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool HIVStatus { get; set; } // true if positive, false if negative
    public DateTime LastAppointmentDate { get; set; }
    // Other relevant properties
}
