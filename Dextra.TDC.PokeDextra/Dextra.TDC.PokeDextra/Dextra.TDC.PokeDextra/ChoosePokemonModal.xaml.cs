﻿using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dextra.TDC.PokeDextra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoosePokemonModal : PopupPage
    {
        public ChoosePokemonModal()
        {
            InitializeComponent();
        }
    }
}