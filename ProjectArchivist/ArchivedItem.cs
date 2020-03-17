using System.Collections.Generic;

/// <summary>
/// Data container for an item that is to be archived into a singular file
/// </summary>
public class ArchivedItem
{
    public string itemName;
    public string sourcePath;
    public string destinationPath;
    public string destinationName;
    public string password;
    public string[] exclusions;
    public Dictionary<string, bool> exclusionRecursiveDefinitions;      // -xr!(exclusion) vs -x!(exclusion)
    public ArchiveType type;                                            // -t(type)
    public int compressionLevel;                                        // -mx=
    public CompressionMethod compressionMethod;                         // -m0=
}

/// <summary>
/// Defines available file types
/// </summary>
public enum ArchiveType
{
    /// <summary>
    /// 7-Zip file format .7z
    /// </summary>
    sevenz,

    /// <summary>
    /// Zip file format .zip
    /// </summary>
    zip
}

/// <summary>
/// Defines available compression methods (only ones available to all ArchiveTypes)
/// </summary>
public enum CompressionMethod
{
    /// <summary>
    /// Lempel–Ziv–Markov
    /// </summary>
    LZMA,

    /// <summary>
    /// Lempel–Ziv–Markov but with better multithreading support 
    /// and occasionally worse compression ratios when on more than 4 threads
    /// </summary>
    LZMAtwo,

    /// <summary>
    /// Based off of Prediction by Partial Matching, best for text files
    /// </summary>
    PPMd,

    /// <summary>
    /// Based off of Burrows–Wheeler algorithm
    /// </summary>
    BZip2
}