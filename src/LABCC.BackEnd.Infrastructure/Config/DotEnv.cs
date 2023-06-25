﻿namespace LABCC.BackEnd.Infrastructure.Config;

public static class DotEnv
{
  public static void Load(string filePath)
  {
    if (!File.Exists(filePath)) 
      throw new FileNotFoundException(".env não foi encontrado, por favor, crie o arquivo na pasta raíz");

    foreach( var line in File.ReadAllLines(filePath) )
    {
      var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

      if (parts.Length != 2) continue;

      Environment.SetEnvironmentVariable(parts[0], parts[1]);
    }
  }

  public static void Load() 
  {
    var appRoot = Directory.GetCurrentDirectory();
    var dotEnv = Path.Combine(appRoot, "../../.env");

    Load(dotEnv);
  }
}
