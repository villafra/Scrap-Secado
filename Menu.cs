using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Scrap_Secado
{
    public partial class Menu : Form
    {
        BLL_KF oBLL_KF;
        public Menu()
        {
            InitializeComponent();
            oBLL_KF = new BLL_KF();
            oBLL_KF.Listar();
        }
    }
}
