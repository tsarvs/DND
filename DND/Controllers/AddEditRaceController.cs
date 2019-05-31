using DND.Models;
using DND.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND.Controllers
{
    public class AddEditRaceController
    {
        private IAddEditRaceForm _view;

        public AddEditRaceController(IAddEditRaceForm view)
        {
            _view = view;
        }
        public void AddEditRace()
        {
            var STR = _view.STR;
            var INT = _view.INT;
            var CHA = _view.CHA;
            var WIS = _view.WIS;
            var DEX = _view.DEX;
            var CON = _view.CON;
            var raceDescription = _view.RaceDescription;
            var raceName = _view.RaceName;
        }

        public void InitializeData()
        {
            using (var db = new DragonDBModel())
            {
                _view.RaceSelector.DataSource =
                    (from r in db.RACE.ToList()
                    select r).ToList();

                _view.RaceSelector.DisplayMember = "r_name";
            }
        }

        public void UpdateRaceControls()
        {
            var selectedRace = (RACE)_view.RaceSelector.SelectedItem;

            _view.RaceName = selectedRace.r_name;
            _view.RaceDescription = selectedRace.r_description;
            _view.INT = selectedRace.ABILITY?.a_INT.GetValueOrDefault(0) ?? 0;
            _view.STR = selectedRace.ABILITY?.a_STR.GetValueOrDefault(0) ?? 0;
            _view.WIS = selectedRace.ABILITY?.a_WIS.GetValueOrDefault(0) ?? 0;
            _view.CHA = selectedRace.ABILITY?.a_CHA.GetValueOrDefault(0) ?? 0;
            _view.DEX = selectedRace.ABILITY?.a_DEX.GetValueOrDefault(0) ?? 0;
            _view.CON = selectedRace.ABILITY?.a_CON.GetValueOrDefault(0) ?? 0;
        }
        public void AddNewRace()
        {
            
        }
    }
}
