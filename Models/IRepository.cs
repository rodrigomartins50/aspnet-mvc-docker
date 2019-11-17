using System.Collections.Generic;

namespace aspnet_mvc_docker.Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos{get;}
    }
}