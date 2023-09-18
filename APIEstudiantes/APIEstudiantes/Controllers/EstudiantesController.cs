using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


//Agregar IAction para usar respuestas de msjs https estandar en los returns de metodos
[Authorize]
[ApiController]
[Route("/api/estudiantes")]
public class EstudianteController : ControllerBase
{
    RepositorioEstudiantes _repositorio = new RepositorioEstudiantes();

    [HttpGet(Name = "GetEstudiantes")]
    public List<Estudiante> Get()
    {
        return _repositorio.ObtenerEstudiantes();
    }

    [HttpGet("{id}")]
    public Estudiante Get(int id)
    {
        return _repositorio.ObtenerEstudianteID(id);
    }

    [HttpPost]
    public Estudiante Post(Estudiante estudiante)
    {
        return  _repositorio.CrearEstudiante(estudiante);
    }

    [HttpPut("{id}")]
    public Estudiante Put(int id, Estudiante estudiante){
        return  _repositorio.ModificarEstudiante(id, estudiante);
    }

    [HttpDelete("{id}")]
    public Estudiante Delete(int id){
        return  _repositorio.EliminarEstudiante(id);
    }
}