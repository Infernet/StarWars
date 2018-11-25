using StarWars.Classes;
using StarWars.Classes.Solders;
using StarWars.Pattern.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars.Forms
{
    public partial class SolderInfoForm : BaseForm
    {
        public SolderInfoForm()
        {
            InitializeComponent();
            this.Text = "Сведения о бойце, " + Singleton.GetSingleton().CurrentSolder.UnitСode;
            string path = Application.StartupPath + @"\Resources\Images\";
            switch (WhatIsSolder())
            {
                case SolderType.Assault:
                    path += @"Assault.png";
                    break;
                case SolderType.Gunner:
                    path += @"Gunner.png";
                    break;
                case SolderType.Recon:
                    path += @"Recon.png";
                    break;
                case SolderType.Sniper:
                    path += @"Sniper.png";
                    break;
                default:
                    break;
            }
            pictureSolderPhoto.Image = Image.FromFile(path);
            pictureSolderPhoto.SizeMode = PictureBoxSizeMode.Zoom;

            textUnitCode.Text = Singleton.GetSingleton().CurrentSolder.UnitСode;
            textRank.Text = Singleton.GetSingleton().CurrentSolder.Rank;
            textWeapon.Text = Singleton.GetSingleton().CurrentSolder.WhatIsWeapon();
            textGadget.Text = Singleton.GetSingleton().CurrentSolder.WhatIsGadgets();
            textSpecialty.Text = Singleton.GetSingleton().CurrentSolder.WhatIsSpecialty();
        }

        private SolderType WhatIsSolder()
        {
            if (Singleton.GetSingleton().CurrentSolder is Assault)
                return SolderType.Assault;
            else if (Singleton.GetSingleton().CurrentSolder is Gunner)
                return SolderType.Gunner;
            else if (Singleton.GetSingleton().CurrentSolder is Recon)
                return SolderType.Recon;
            else if (Singleton.GetSingleton().CurrentSolder is Sniper)
                return SolderType.Sniper;
            else
                Environment.Exit(5);
                return SolderType.Assault;
                 
        }
    }
}
