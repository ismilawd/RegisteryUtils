using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteryApi.Registery
{
    public class RegistryValue
    {
        public string Name { get; set; }
        public RegistryValueKind ValueKind { get; set; }
        public object Value { get; set; }
    }
}
