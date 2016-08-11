using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuartzArchitecture.Service
{
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        public ProjectInstaller(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
