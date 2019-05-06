using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND.Views.Interfaces
{
    public interface INewFeatForm
    {
        TextBox FeatName { get; set; }

        TextBox FeatSource { get; set; }

        TextBox FeatDescription { get; set; }
    }
}
