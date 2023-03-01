using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Assignment
{
    public List<Developer> DeveloperList { get; set; }
    public List<Project> ProjectList { get; set; }
    public int NumberDeveloper { get; set; }
    public int NumberProject { get; set; }


    public Assignment(int NumberDeveloper, int NumberProject) 
    {
        //Para guardar las cantidades de entrada
        this.NumberDeveloper = NumberDeveloper;
        this.NumberProject = NumberProject;

        //Para la creación de los objetos
        CreateDevelopers(NumberDeveloper);
        CreateProjects(NumberProject);
    }

    public void CreateDevelopers(int NumberDeveloper)
    {
        //Lógica para creación de desarrolladores
        Console.WriteLine("Lógica para creación de desarrolladores");
    }

    public void CreateProjects(int NumberProject)
    {
        //Lógica para creación de proyectos
        Console.WriteLine("Lógica para creación de proyectos");
    }

    /* SEECIONADO PARA MAYOR ENTENDIMIENTO, SE PODRÍA HACER TODO EN UNA SOLA FUNCIÓN*/

    public void DevToProjectsCreateRelations(int indexDeveloper, int indexProject)
    {
        //Lógica para establecer la relación de un desarrollador a muchos proyectos
        Console.WriteLine("Lógica para establecer la relación de un desarrollador a muchos proyectos");
    }

    public void ProjectToDevCreateRelation(int indexDeveloper, int indexProject)
    {
        //Lógica para establecer la relación de un proyecto a un desarrollador
        Console.WriteLine("Lógica para establecer la relación de un proyecto a un desarrollador");
    }
        
    public void DevToProjectsRemoveRelations(int indexDeveloper, int indexProject)
    {
        //Lógica para anular la relación de un desarrollador a muchos proyectos
        Console.WriteLine("Lógica para anular la relación de un desarrollador a muchos proyectos");
    }

    public void ProjectToDevRemoveRelation(int indexDeveloper, int indexProject)
    {
        //Lógica para anular la relación de un proyecto a un desarrollador
        Console.WriteLine("Lógica para anular la relación de un proyecto a un desarrollador");
    }

    /* ------------------------------------------------------------------------------------*/

    public void FinishProjectByDate()
    {
        //Lógica para finalizar el proyecto dependiendo de la fecha de finalización
        Console.WriteLine("Lógica para finalizar el proyecto dependiendo de la fecha de finalización");
    }

    public void FinishProjectByHours()
    {
        //Lógica para finalizar el proyecto dependiendo de las horas
        Console.WriteLine("Lógica para finalizar el proyecto dependiendo de las horas");
    }

}

