using Dominio.Especifications;
using Dominio.Repositories.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TEntity entity);
        TEntity Update(int id, TEntity entity);
        TEntity Delete(int id);
        IEnumerable<TEntity> Filter(ISpecification<TEntity> especificaciones);
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);
        TEntity GetFirs(Func<TEntity, bool> predicate);
        IGenericRepository<TEntity> Specify(Ardalis.Specification.ISpecification<TEntity> specification);
        IPagina<TEntity> Paginar(IConsulta ownerParameters);
        IQueryable<TEntity> WithSpecs();
    }
}
