using Ardalis.Specification.EntityFrameworkCore;
using Dominio.Especifications;
using Dominio.Models;
using Dominio.Repositories;
using Dominio.Repositories.Extensions;
using Infraestructura.Data;
using Infraestructura.Repositories.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infraestructura.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly MovieContext _dbContext;

        private List<Ardalis.Specification.ISpecification<TEntity>> Specs { get; }
        public GenericRepository(MovieContext dbContext)
        {
            _dbContext = dbContext;
            Specs = new List<Ardalis.Specification.ISpecification<TEntity>>();
        }


        public TEntity Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return entity;
        }

        public TEntity Delete(int id)
        {
            var entity = GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            return entity;
        }

        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            var resultado = _dbContext.Set<TEntity>().AsNoTracking().Where(predicate);

            return resultado;
        }

        public TEntity GetFirs(Func<TEntity, bool> predicate)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> Filter(ISpecification<TEntity> especificaciones)
        {
            var resultado = _dbContext.Set<TEntity>().AsNoTracking().Where(especificaciones.Traer());

            return resultado;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public TEntity Update(int id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return entity;
        }

        public IGenericRepository<TEntity> Specify(Ardalis.Specification.ISpecification<TEntity> specification)
        {
            this.Specs.Add(specification);
            return this;
        }

        public IQueryable<TEntity> WithSpecs()
        {
            var query = _dbContext.Set<TEntity>().OrderBy(on => on.Id).AsQueryable();
            var queryable = Specs.Aggregate(query,
                (current, spec) => new SpecificationEvaluator<TEntity>().GetQuery(current, spec));
            Specs.Clear();
            return queryable;
        }

        public IPagina<TEntity> Paginar(IConsulta ownerParameters)
        {
            var ff = PagedList<TEntity>.ToPagedList(WithSpecs().AsQueryable(),
                ownerParameters.PageNumber,
                ownerParameters.PageSize);
            return ff;
        }
    }
}
