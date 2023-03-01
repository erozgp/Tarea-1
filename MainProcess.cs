using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tarea_1
{
    public class MainProcess
    {
        public static void Main(string[] args)
        {
            Assignment NewAssig = new Assignment(2, 3);

            NewAssig.DevToProjectsCreateRelations(0, 0);
            NewAssig.ProjectToDevCreateRelation(0, 0);
            NewAssig.DevToProjectsRemoveRelations(0, 0);
            NewAssig.ProjectToDevRemoveRelation(0, 0);

        }
    }
}
