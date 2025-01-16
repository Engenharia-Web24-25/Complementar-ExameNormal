using System;
using EW_NOR2024.Models;

namespace EW_NOR2024.Data
{
    public class DbInitializer
    {
        private ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Run()
        {
            _context.Database.EnsureCreated();

            if (_context.Priorities.Any() == false)
            {
                var _priorities = new Priority[]
                {
                    new Priority { Name = "High", Rank = 1 },
                    new Priority { Name = "Medium", Rank = 2 },
                    new Priority { Name = "Low", Rank = 3 }
                };

                _context.Priorities.AddRange(_priorities);
            }

            if (_context.Events.Any() == false)
            {

                var _events = new Event[]
                {
                    new Event { Title = "Exame EW - NOR", Description = "Exame de Engenharia Web - Época Normal", When = new DateTime(2025,01,21,16,0,0), Protected = false },
                    new Event { Title = "Reunião Projeto A-Mover", Description = "Reunião de equipas do Projeto A-Mover", When = new DateTime(2025,01,22,9,30,0), Protected = true },
                    new Event { Title = "Exame EW - REC", Description = "Exame de Engenharia Web - Época de Recurso", When = new DateTime(2025,02,04,16,0,0), Protected = false },
                    new Event { Title = "Reunião de Departamento", Description = "Reunião do Departamento de Engenharias", When = new DateTime(2025,01,28,16,30,0), Protected = true }
                };

                _context.Events.AddRange(_events);
            }

            _context.SaveChanges();
        }
    }
}
