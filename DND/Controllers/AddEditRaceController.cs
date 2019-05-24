using DND.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Controllers
{
    class AddEditRaceController
    {
        private IAddEditRaceForm _view;

        public AddEditRaceController(IAddEditRaceForm view)
        {
            _view = view;            
        }



    }
}
