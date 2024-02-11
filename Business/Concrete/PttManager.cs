using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    public class PttManager:ISupplierService
    {
        IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName+" "+person.LastName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName+ " " + person.LastName + " için maske verilemedi.");
            }
        }
    }
}
