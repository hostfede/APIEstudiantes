

public class RepositorioEstudiantes{

    private static List<Estudiante> ListaEstudiantes = new List<Estudiante>
        {
            new Estudiante { ID = 1, Nombre = "Juan", Apellido = "Pérez", FechaNacimiento = new DateTime(2000, 1, 15), Email = "juan@example.com" },
            new Estudiante { ID = 2, Nombre = "María", Apellido = "González", FechaNacimiento = new DateTime(1999, 5, 20), Email = "maria@example.com" },
        };

    public List<Estudiante> ObtenerEstudiantes(){
        return ListaEstudiantes;
    }

    public Estudiante ObtenerEstudianteID(int ID){
        Estudiante estudiante = ListaEstudiantes.FirstOrDefault(estudiante => estudiante.ID == ID);
                if (estudiante == null)
                {
                    return null;
                }
                return estudiante;
    }

    public Estudiante CrearEstudiante(Estudiante estudiante){
        ListaEstudiantes.Add(estudiante);
        return estudiante;
    }
    
     public Estudiante ModificarEstudiante(int id, Estudiante newEstudiante){
        Estudiante oldEstudiante = ListaEstudiantes.FirstOrDefault(estudiante => estudiante.ID == id);
        if (oldEstudiante == null){
            return null;
        }
        oldEstudiante.Nombre = newEstudiante.Nombre;
        oldEstudiante.Apellido = newEstudiante.Apellido;
        oldEstudiante.Email = newEstudiante.Email;
        oldEstudiante.FechaNacimiento = newEstudiante.FechaNacimiento;
        return oldEstudiante;
    }

    public Estudiante EliminarEstudiante(int id){
        Estudiante estudiante = ListaEstudiantes.FirstOrDefault(estudiante => estudiante.ID == id);
        if (estudiante == null){
            return null;
        }
        ListaEstudiantes.Remove(estudiante);
        return estudiante;
    }
}

