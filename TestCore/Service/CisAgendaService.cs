using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestCore.Models
{
    public class CisAgendaService
    {
        List<CisAgenda> cisAgendas = new List<CisAgenda>()
        {
            new CisAgenda("test4"),
            new CisAgenda("test5"),
            new CisAgenda("test6"),
            new CisAgenda("test7")
        };

        public async Task<List<CisAgenda>> GetCisAgendas()
        {
            return await Task.FromResult(cisAgendas);
        }
    }
}
