using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Views.Interfaces
{
    public interface IAddEditProficiencyForm
    {
        string ProficiencyType { get; set; }

        string ProficiencyName { get; set; }
    }
}
