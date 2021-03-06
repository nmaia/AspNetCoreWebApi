﻿using Project.Domain.Contracts.Repositories;
using Project.Domain.Entities;
using Project.Repository.Repositories.Common;
using System.Linq;

namespace Project.Repository.Repositories
{
    public class PlanetRepository : RepositoryBase<Planet>, IPlanetRepository
    {
        public override Planet GetByNameAsync(string planetName)
            => db.Set<Planet>().SingleOrDefault(p => p.Name.ToLower() == planetName.ToLower());
    }
}
