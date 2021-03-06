﻿using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace Toolbox.Common.Features.OnAirLight
{
    public interface IActiveProcessesService
    {
        IObservableList<string> ProcessNames { get; }
        IObservableList<string> WindowTitles { get; }

    }
}
