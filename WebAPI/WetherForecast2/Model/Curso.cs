namespace WetherForecast2.Model
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Area { get; set; }

        public string Duracao { get; set; }

        public List<Disciplina> Disciplinas { get; set; }

        public Curso()
        {
            Disciplinas = new List<Disciplina>();
        }
    }


public static class CursoEndpoints
{
	public static void MapCursoEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Curso", () =>
        {
            return new [] { new Curso() };
        })
        .WithName("GetAllCursos")
        .Produces<Curso[]>(StatusCodes.Status200OK);

        routes.MapGet("/api/Curso/{id}", (int id) =>
        {
            //return new Curso { ID = id };
        })
        .WithName("GetCursoById")
        .Produces<Curso>(StatusCodes.Status200OK);

        routes.MapPut("/api/Curso/{id}", (int id, Curso input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateCurso")
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Curso/", (Curso model) =>
        {
            //return Results.Created($"/Cursos/{model.ID}", model);
        })
        .WithName("CreateCurso")
        .Produces<Curso>(StatusCodes.Status201Created);

        routes.MapDelete("/api/Curso/{id}", (int id) =>
        {
            //return Results.Ok(new Curso { ID = id });
        })
        .WithName("DeleteCurso")
        .Produces<Curso>(StatusCodes.Status200OK);
    }
}}
