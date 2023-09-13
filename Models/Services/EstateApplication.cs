using FluxEstates.Models.Abstract;
using FluxEstates.Models.Concreate.Subclasses;
using FluxEstates.Models.Distinct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxEstates.Models.Services
{
    public class EstateApplication
    {
        public List<Estate> ListOfEstate;

        public void ResetListOfEstate()
        {
            ListOfEstate = new List<Estate>();
        }

        public void AddEstate(Estate estate)
        {
            if (ListOfEstate == null)
            {
                ResetListOfEstate();
            }
            var savecheck = ListOfEstate?.FirstOrDefault(x => x.Id == estate.Id);
            if (savecheck == null)
            {
                ListOfEstate?.Add(estate);
            }

        }
        public Estate GetEstate(int Id)
        {
            if (ListOfEstate == null)
            {
                ResetListOfEstate();
            }
            var resp = ListOfEstate?.FirstOrDefault(x => x.Id == Id);
            return resp ?? default;
        }
        public void updateEstate(Estate estate)
        {
            ListOfEstate[ListOfEstate.FindIndex(x => x.Id == estate.Id)] = estate;
        }
        public void deleteEstate(Estate estate)
        {
            ListOfEstate.Remove(estate);
        }

        public int GetNewIdForObject()
        {
            if (ListOfEstate == null)
            {
                return 1;

            }
            if (ListOfEstate.Count == 0)
            {
                return 1;
            }
            int highestnumber = ListOfEstate.Select(x => x.Id).Max();
            return highestnumber + 1;
        }

    }

}

