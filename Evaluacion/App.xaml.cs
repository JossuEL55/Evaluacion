<<<<<<< HEAD
﻿namespace Evaluacion
{
    public partial class App : Application
    {
=======
﻿using Evaluacion.Repositories;

namespace Evaluacion
{
    public partial class App : Application
    {
        public static CountryRepository CountryRepo { get; private set; }

>>>>>>> Agregar archivos de proyecto.
        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            MainPage = new AppShell();
        }
    }
}
=======
            CountryRepo = new CountryRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "countries.db3"));

            MainPage = new NavigationPage(new Views.CountryModel());
        }
    }
}
>>>>>>> Agregar archivos de proyecto.
