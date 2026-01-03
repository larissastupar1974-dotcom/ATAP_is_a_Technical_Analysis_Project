// <copyright file="ReadCsv.cs" company="LarissaStupar1974">
// Copyright (c) LarissaStupar1974. All rights reserved.
// </copyright>

namespace DataLoader;

using System.Globalization;
using CsvHelper;

/// <summary>
/// Read csv.
/// </summary>
public static class ReadCsv
{
    /// <summary>
    /// Read.
    /// </summary>
    public static void Read()
    {
        string path = @"C:\\Users\\rayfi\\Downloads\\NDEX-20260103-KUUQF8V6AA\Tfm1Yearohlcv-1d.csv";
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<dynamic>();
    }
}
