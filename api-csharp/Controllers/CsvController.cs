using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using CsvHelper;
using CsvImporterApi.Data;
using CsvImporterApi.Models;

[Route("api/csv")]
[ApiController]
public class CsvController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CsvController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadCsv([FromForm] IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Arquivo CSV não enviado.");

        try
        {
            using (var stream = new StreamReader(file.OpenReadStream()))
            using (var csv = new CsvReader(stream, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Record>().ToList();

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        // Ativa o IDENTITY_INSERT na tabela Records
                        await _context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT Records ON;");

                        // Insere os registros do CSV
                        _context.Records.AddRange(records);
                        await _context.SaveChangesAsync();

                        // Desativa o IDENTITY_INSERT após a inserção
                        await _context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT Records OFF;");

                        // Confirma a transação
                        await transaction.CommitAsync();
                    }
                    catch
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }

            return Ok(new { message = "Importação concluída com sucesso!" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao importar CSV: {ex.Message}");
        }
    }
}
