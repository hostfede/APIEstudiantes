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
    [Authorize("read:estudiantes")]
    public List<Estudiante> Get()
    {
        return _repositorio.ObtenerEstudiantes();
    }

    [HttpGet("{id}")]
    [Authorize("read:estudiantes")]
    public Estudiante Get(int id)
    {
        return _repositorio.ObtenerEstudianteID(id);
    }

    [HttpPost]
    [Authorize("write:estudiantes")]
    public Estudiante Post(Estudiante estudiante)
    {
        return  _repositorio.CrearEstudiante(estudiante);
    }

    [HttpPut("{id}")]
    [Authorize("write:estudiantes")]
    public Estudiante Put(int id, Estudiante estudiante){
        return  _repositorio.ModificarEstudiante(id, estudiante);
    }

    [HttpDelete("{id}")]
    [Authorize("write:estudiantes")]
    public Estudiante Delete(int id){
        return  _repositorio.EliminarEstudiante(id);
    }
}