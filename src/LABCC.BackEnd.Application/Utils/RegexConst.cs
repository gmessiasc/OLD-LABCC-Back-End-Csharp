﻿using System.Text.RegularExpressions;

namespace LABCC.BackEnd.Application.Utils;

public static partial class RegexConst
{
  [GeneratedRegex(@"\D")]
  public static partial Regex NotNumericalDigitRegex();

  public static Regex NotNumerical = NotNumericalDigitRegex();

}
