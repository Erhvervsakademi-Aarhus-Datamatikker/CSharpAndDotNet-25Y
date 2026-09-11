namespace TodoApp.DTOs;

using System.ComponentModel.DataAnnotations;



public class CreateTaskDto
{
    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class UpdateTaskDto
{
    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}