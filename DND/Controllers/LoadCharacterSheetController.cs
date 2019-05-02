using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DND.Models;
using DND.Views.Enums;
using DND.Views.Forms;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class LoadCharacterSheetController
    {
        #region Properties

        private ILoadCharacterSheetForm _view;

        #endregion

        #region Constructor

        public LoadCharacterSheetController(ILoadCharacterSheetForm view)
        {
            _view = view;

            PopulateGrid();
        }

        #endregion

        #region Methods

        public void LoadCharacter()
        {
            var selectedId = Convert.ToInt32(_view.CharacterGridView.SelectedRows[0].Cells[0].Value);

            var form = new CharacterSheetForm();

            form.SetController(new CharacterSheetController(form));

            form.LoadCharacter(selectedId);

            form.ShowDialog();
        }

        private void PopulateGrid()
        {
            using (var db = new DragonDBModel())
            {
                var gridContent = from ch in db.CHARACTER.ToList()
                                  select new
                                  {
                                      ID = ch.c_id,
                                      Name = ch.c_name,
                                      Race = ch.RACE.r_name,
                                      isNPC = ch.c_isNPC
                                  };

                _view.CharacterGridView.DataSource = gridContent.ToList();
            }

            SetGridViewStyling();
        }

        private void SetGridViewStyling()
        {
            foreach (DataGridViewColumn column in _view.CharacterGridView.Columns)
            {
                switch (column.Name)
                {
                    case ("ID"):
                        column.Width = 25;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case ("Name"):
                        column.Width = 110;
                        break;
                    case ("Race"):
                        column.Width = 85;
                        break;
                    case ("isNPC"):
                        column.Width = 50;
                        break;
                }
            }
        }

        #endregion
    }
}
