using CsvImporterApi.Data;
using CsvImporterApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CsvImporterApi.Services
{
    public class CsvService
    {
        private readonly ApplicationDbContext _context;

        public CsvService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ImportCsvAsync(string filePath)
        {
            var lines = await File.ReadAllLinesAsync(filePath);
            var records = lines.Skip(1)
                .Select(line =>
                {
                    var data = line.Split(',');
                    return new Record
                    {
                        Nome = data[0],
                        Idade = int.Parse(data[1], CultureInfo.InvariantCulture),
                        Cidade = data[2],
                        Profissao = data[3]
                    };
                }).ToList();

            _context.Records.AddRange(records);
            await _context.SaveChangesAsync();
        }
    }
}
