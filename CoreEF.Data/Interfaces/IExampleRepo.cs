using System.Collections.Generic;
using CoreEF.Data.Models;
using System.Threading.Tasks;
using System.Linq;
using CoreEF.Data.ViewModels;

namespace CoreEF.Data.Interfaces
{
    public interface IExampleRepo
    {
        Task<IEnumerable<Example>> getExamples();
        Task<int> insert(ExampleVM vm);
    }
}
