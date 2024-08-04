using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomlyn.Model;

namespace VH_Server_Installer.Resources.FileTypes
{
    internal class Eula : ITomlMetadataProvider
    {
        TomlPropertiesMetadata? ITomlMetadataProvider.PropertiesMetadata { get; set; }
        public bool eula {  get; set; }
    }
}
