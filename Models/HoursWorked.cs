namespace SimpleTimeClock.Models;

public class HoursWorked
{
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    public DateTime? ClockIn { get; set; }

    public DateTime? ClockOut { get; set; }

    public DateTime? StartLunch { get; set; }

    public DateTime? EndLunch { get; set; }

    public decimal? DailyHoursWorked { get; set; }

    public decimal? WeeklyHoursWorked { get; set; }
}