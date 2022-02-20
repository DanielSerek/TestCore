using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCore.Datalayer;
using TestCore.Models;

namespace TestCore.Pages
{
    public partial class Agenda
    {

        [Inject] DBContext cisDBContext { get; set; }

        public List<CisAgenda> agendas;

        //protected override async Task OnParametersSetAsync()
        //{
        //    await base.OnParametersSetAsync();

        //    int c = cisDBContext.Agendas.Count();

        //    agendas = cisDBContext.Agendas.ToList();
        //}



    } 
}
