﻿using Day.Office.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day.Office.Api.Data.Repositories
{
    public interface IEscritorioRepository
    {
        Task<IEnumerable<Escritorio>> ObterEscritorios();
    }
}
