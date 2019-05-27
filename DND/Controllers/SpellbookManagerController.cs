using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND.Models;
using DND.Views.Interfaces;

namespace DND.Controllers
{
    public class SpellbookManagerController
    {
        private ISpellbookManagerForm _view;

        private ICharacterSheetForm _parentView;

        private List<SPELLS> _dbSpells;

        private BindingList<SPELLS> _loadedSpells;

        private BindingList<SPELLS> _loadedCharacterSpells;

        public SpellbookManagerController(ISpellbookManagerForm view, ICharacterSheetForm parentView, List<SPELLS> loadedCharacterSpells)
        {
            _view = view;
            _parentView = parentView;

            using (var db = new DragonDBModel())
            {
                _dbSpells = db.SPELLS.ToList();
            }

            _loadedSpells = new BindingList<SPELLS>();
            _loadedCharacterSpells = new BindingList<SPELLS>(loadedCharacterSpells);

            _view.SpellsListBox.DataSource = _loadedSpells;
            _view.SpellsListBox.DisplayMember = "s_name";
            _view.SpellsListBox.ValueMember = "s_id";

            _view.CharacterSpellsListBox.DataSource = _loadedCharacterSpells;
            _view.CharacterSpellsListBox.DisplayMember = "s_name";
            _view.CharacterSpellsListBox.ValueMember = "s_id";
            
            UpdateListDisplays();

            UnselectCharacterSpells();
            UnselectSpells();
        }

        public void UnselectSpells()
        {
            _view.SpellsListBox.ClearSelected();
        }

        public void UnselectCharacterSpells()
        {
            _view.CharacterSpellsListBox.ClearSelected();
        }

        public void AddSpellsToCharacter()
        {
            var selectedSpells = _view.SpellsListBox.SelectedItems.Cast<SPELLS>().ToList();

            foreach (var spell in selectedSpells)
            {
                var spellToAddToCharacter = new SPELLS
                {
                    s_id = spell.s_id,
                    s_name = spell.s_name,
                    s_school = spell.s_school,
                    s_level = spell.s_level,
                    s_castingtime = spell.s_castingtime,
                    s_range = spell.s_range,
                    s_target = spell.s_target,
                    s_component_m = spell.s_component_m,
                    s_component_s = spell.s_component_s,
                    s_component_v = spell.s_component_v,
                    s_isconcentration = spell.s_isconcentration,
                    s_durationminutes = spell.s_durationminutes,
                    s_description = spell.s_description
                };

                _loadedCharacterSpells.Add(spellToAddToCharacter);

                _loadedSpells.Remove(_loadedSpells.First(x => x.s_id == spellToAddToCharacter.s_id));
            }

            UpdateCharacterSpellsSelection(selectedSpells);

            UpdateSpellDescription(false);
        }

        public void RemoveSpellsFromCharacter()
        {
            var selectedSpells = _view.CharacterSpellsListBox.SelectedItems.Cast<SPELLS>().ToList();

            foreach (var spell in selectedSpells)
            {
                var spellToRemoveFromCharacter = new SPELLS
                {
                    s_id = spell.s_id,
                    s_name = spell.s_name,
                    s_school = spell.s_school,
                    s_level = spell.s_level,
                    s_castingtime = spell.s_castingtime,
                    s_range = spell.s_range,
                    s_target = spell.s_target,
                    s_component_m = spell.s_component_m,
                    s_component_s = spell.s_component_s,
                    s_component_v = spell.s_component_v,
                    s_isconcentration = spell.s_isconcentration,
                    s_durationminutes = spell.s_durationminutes,
                    s_description = spell.s_description
                };

                _loadedSpells.Add(spellToRemoveFromCharacter);

                _loadedCharacterSpells.Remove(_loadedCharacterSpells.First(x => x.s_id == spellToRemoveFromCharacter.s_id));
            }

            UpdateSpellsSelection(selectedSpells);

            UpdateSpellDescription(true);
        }

        public void UpdateSpellDescription(bool updateDescriptionFromSpellList)
        {
            SPELLS selectedSpell;

            if (updateDescriptionFromSpellList)
                selectedSpell = (SPELLS)_view.SpellsListBox.SelectedItem;
            else
                selectedSpell = (SPELLS)_view.CharacterSpellsListBox.SelectedItem;

            _view.SpellDescription = "";

            GenerateSpellDescription(selectedSpell);
        }

        public void UpdateCharacterSheet()
        {
            var characterSpells = _view.CharacterSpellsListBox.Items.Cast<SPELLS>().ToList();

            _parentView.AddSpells(characterSpells);
        }

        private void GenerateSpellDescription(SPELLS selectedSpell)
        {
            if (selectedSpell != null)
            {
                if (!selectedSpell.s_name.Equals(""))
                {
                    _view.SpellDescription += selectedSpell.s_name + "\r\n";
                }

                if (!selectedSpell.s_school.Equals(""))
                {
                    _view.SpellDescription += selectedSpell.s_school + " ";
                }

                if (selectedSpell.s_level != null)
                {
                    _view.SpellDescription += "lvl " + selectedSpell.s_level.ToString() + "\r\n";
                }
                else if (!selectedSpell.s_school.Equals(""))
                {
                    _view.SpellDescription += "\r\n";
                }

                if (!selectedSpell.s_range.Equals(""))
                {
                    _view.SpellDescription += "Range: " + selectedSpell.s_range + "\r\n";
                }

                if (!selectedSpell.s_target.Equals(""))
                {
                    _view.SpellDescription += "Target: " + selectedSpell.s_target + "\r\n";
                }

                if (selectedSpell.s_castingtime != null)
                {
                    _view.SpellDescription += "Casting Time: " + selectedSpell.s_castingtime.ToString() + "\r\n";
                }

                if (selectedSpell.s_durationminutes != null)
                {
                    _view.SpellDescription += "Duration: " + selectedSpell.s_durationminutes.ToString() + "\r\n";
                }

                if (selectedSpell.s_isconcentration != null)
                {
                    _view.SpellDescription += "Concentration: " + (selectedSpell.s_isconcentration.GetValueOrDefault(false) ? "Y" : "N") + "\r\n";
                }

                if ((selectedSpell.s_component_m != null) || (selectedSpell.s_component_s != null) || (selectedSpell.s_component_v != null))
                {
                    _view.SpellDescription += "Components: ";

                    if (selectedSpell.s_component_m != null && !selectedSpell.s_component_m.Equals(""))
                    {
                        _view.SpellDescription += "M (" + selectedSpell.s_component_m + ") ";
                    }

                    if (selectedSpell.s_component_s != null && selectedSpell.s_component_s == true)
                    {
                        _view.SpellDescription += "S ";
                    }

                    if (selectedSpell.s_component_v != null && selectedSpell.s_component_v == true)
                    {
                        _view.SpellDescription += "V ";
                    }

                    _view.SpellDescription += "\r\n";
                }

                if (selectedSpell.s_description != null && !selectedSpell.s_description.Equals(""))
                {
                    _view.SpellDescription += "\r\n"+selectedSpell.s_description;
                }

            }
        }

        private void UpdateSpellsSelection(List<SPELLS> selectedSpells)
        {
            _view.SpellsListBox.ClearSelected();

            foreach (var spell in selectedSpells)
            {
                var spellToSelect =
                    (from s in _view.SpellsListBox.Items.Cast<SPELLS>()
                        where (s.s_id == spell.s_id)
                        select s).First();

                var index = _view.SpellsListBox.Items.IndexOf(spellToSelect);

                _view.SpellsListBox.SetSelected(index, true);
            }
        }
        
        private void UpdateCharacterSpellsSelection(List<SPELLS> selectedSpells)
        {
            _view.CharacterSpellsListBox.ClearSelected();

            foreach (var spell in selectedSpells)
            {
                var spellToSelect =
                    (from s in _view.CharacterSpellsListBox.Items.Cast<SPELLS>()
                        where (s.s_id == spell.s_id)
                        select s).First();

                var index = _view.CharacterSpellsListBox.Items.IndexOf(spellToSelect);

                _view.CharacterSpellsListBox.SetSelected(index, true);
            }
        }

        private void UpdateListDisplays()
        {
            _loadedSpells.Clear();
            
            foreach (var dbSpell in _dbSpells)
            {
                _loadedSpells.Add(new SPELLS
                {
                    s_id = dbSpell.s_id,
                    s_name = dbSpell.s_name,
                    s_school = dbSpell.s_school,
                    s_level = dbSpell.s_level,
                    s_castingtime = dbSpell.s_castingtime,
                    s_range = dbSpell.s_range,
                    s_target = dbSpell.s_target,
                    s_component_m = dbSpell.s_component_m,
                    s_component_s = dbSpell.s_component_s,
                    s_component_v = dbSpell.s_component_v,
                    s_isconcentration = dbSpell.s_isconcentration,
                    s_durationminutes = dbSpell.s_durationminutes,
                    s_description = dbSpell.s_description
                });
            }

            foreach (var spell in _loadedCharacterSpells)
            {
                _loadedSpells.Remove(_loadedSpells.First(x => x.s_id == spell.s_id));
            }
        }
    }
}
