﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematics.Intrrr
{
    interface ICalcult
    {
        double Calcul(int count, double upLim, double downLim, Func<double, double> integral);
    }
}
