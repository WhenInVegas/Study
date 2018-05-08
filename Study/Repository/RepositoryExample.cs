using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Study.Repository
{
    class RepositoryExample
    {
    }

    public class IEntity
    {
        public string Id;
    }

    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T enity);
        void Update(T endity);
        T FindByEnity(int Id);
    }

    public partial class Author : IEntity
    {
        public int Id { get; set; }
        
        public string AuthorName { get; set; }
    }

    public class AuthorRepository : IRepository<Author>
    {
     //   private Model1 _authorContext;

        public IEnumerable<Author> List { get; }
        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author enity)
        {
            throw new NotImplementedException();
        }

        public void Update(Author endity)
        {
            throw new NotImplementedException();
        }

        public Author FindByEnity(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
