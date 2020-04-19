using System.Collections.Generic;
using System.IO;

public interface IDatabaseHandler
{
    /// <summary>
    /// Saves data
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    bool SaveData(Data data);

    /// <summary>
    /// Connects to database
    /// </summary>
    /// <param name="type"></param>
    /// <param name="mode"></param>
    /// <param name="fileAccess"></param>
    /// <returns></returns>
    bool ConnectToDatabase(string type, FileMode mode, FileAccess fileAccess);

    /// <summary>
    /// Disconnects from database
    /// </summary>
    void DisconnectDatabase();

    /// <summary>
    /// Finds an returns data according to its type
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    Data FindDataByType(string type);
}