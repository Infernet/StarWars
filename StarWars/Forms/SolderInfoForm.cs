using StarWars.Classes;
using StarWars.Classes.Solders;
using System;
using System.Drawing;
using System.Windows.Forms;
using StarWars.Pattern.Singleton;

namespace StarWars.Forms
{
    public partial class SolderInfoForm : BaseForm
    {
        public SolderInfoForm()
        {
            InitializeComponent();
            this.Text = "Сведения о бойце, " + Client.GetInstance().CurrentSolder.UnitСode;
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

            textUnitCode.Text = Client.GetInstance().CurrentSolder.UnitСode;
            textRank.Text = Client.GetInstance().CurrentSolder.Rank;
            textWeapon.Text = Client.GetInstance().CurrentSolder.WhatIsWeapon();
            textGadget.Text = Client.GetInstance().CurrentSolder.WhatIsGadgets();
            textSpecialty.Text = Client.GetInstance().CurrentSolder.WhatIsSpecialty();
        }

        private SolderType WhatIsSolder()
        {
            if (Client.GetInstance().CurrentSolder is Assault)
                return SolderType.Assault;
            else if (Client.GetInstance().CurrentSolder is Gunner)
                return SolderType.Gunner;
            else if (Client.GetInstance().CurrentSolder is Recon)
                return SolderType.Recon;
            else if (Client.GetInstance().CurrentSolder is Sniper)
                return SolderType.Sniper;
            else
                Environment.Exit(5);
                return SolderType.Assault;
                 
        }
    }
}
