﻿using System;
using System.Globalization;

namespace Leanwork.CodePack.Mvc
{
    public class DecimalModelBinder : ModelBinder
    {
        public override object ConvertTo(string value)
        {
            return Convert.ToDecimal(value, CultureInfo.CurrentCulture);
        }
    }
}
