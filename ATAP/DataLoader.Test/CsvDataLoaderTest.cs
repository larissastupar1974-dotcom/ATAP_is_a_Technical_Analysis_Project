// <copyright file="CsvDataLoaderTest.cs" company="LarissaStupar1974">
// Copyright (c) LarissaStupar1974. All rights reserved.
// </copyright>

namespace DataLoader.Test;

using DataLoader;

/// <summary>
/// Test the csv data loader.
/// </summary>
public class CsvDataLoaderTest
{
    /// <summary>
    /// Test reading initial data.
    /// </summary>
    [Fact]
    public void ReadInitialDataTest()
    {
        ReadCsv.Read();
    }
}