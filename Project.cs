using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Project
{
    public string Name { get; set; }
    public int Category { get; set; }
    public int HoursDuration { get; set; }
    public DateTime StartDate { get; set; }
    public Developer Developer { get; set; }
        
        

    public Project(string Name, int Category, int HoursDuration, DateTime StartDate)
    {
        this.Name = Name;
        this.Category = Category;
        this.HoursDuration = HoursDuration;
        this.StartDate = StartDate;
        this.Developer = null;
    }

    //Para pruebas
    public Project(String Name)
    {
        this.Name = Name;
    }

    public void AddDeveloper(Developer developer)
    {
        Developer = developer;
    }

    public void RemoveDeveloper(Developer developer)
    {
        Developer = null;
    }
}

