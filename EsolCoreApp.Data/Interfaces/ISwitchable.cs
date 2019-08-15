using EsolCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsolCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    } 
}
