using FluxEstates.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxEstates
{
    public class StateContainer
    {


        public List<IEstate> estates;

        async Task AddNewEstate(IEstate estate)
        {
            estates.Add(estate);
        }
        async Task UpdateEstate(IEstate estate)
        {
            var estateToUpdate = estates.FirstOrDefault(x => x.Id == estate.Id);
            if (estateToUpdate != null)
            {
                estateToUpdate = estate;
            }
        }

        async Task DeleteEstate(IEstate estate)
        {
            var estateToDelete = estates.FirstOrDefault(x => x.Id == estate.Id);
            if (estateToDelete != null)
            {
                estates.Remove(estateToDelete);
            }
        }
    }
}
