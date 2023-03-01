using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class Developer
{
    public string Name { get; set; }
    public DateTime DateAdmission { get; set; }
    public string Email { get; set; }
    public int Category { get; set; }
    public List<Project> Projects { get; set; }

    public Developer(string Name, DateTime DateAdmission, string Email, int Category)
    {
        this.Name = Name;
        this.DateAdmission = DateAdmission;
        this.Email = Email;
        this.Category = Category;
        this.Projects = new List<Project>();
    }

    //Para pruebas
    public Developer(String Name)
    {
        this.Name = Name;
    }

    public void AddProject(Project project)
    {
        Projects.Add(project);
    }

    public void RemoveProject(Project project)
    {
        Projects.Remove(project);
    }

    public void TotalHoursRecord(Project project)
    {
        //Se obtendrán las horas restantes y el total actual.
        Console.WriteLine("Se obtendrán las horas restantes y el total actual.");
    }

    public void HoursWorked(Project project, int horas)
    {
        //Se ingresarán las horas trabajadas y se actualizará en el proyecto.
        Console.WriteLine("Se ingresarán las horas trabajadas y se actualizará en el proyecto.");
    }
}