using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class LocalDBHandler : IDatabaseHandler
{
    private BinaryFormatter m_BinaryFormatter;
    private FileStream m_Stream;

    public enum DataType
    {
        player,
        settings
    }

    public bool ConnectToDatabase(string type, FileMode mode)
    {
        m_BinaryFormatter = new BinaryFormatter();
        string savePath = Application.persistentDataPath + $"/{type}.data";
        m_Stream = null;

        try
        {
            m_Stream = new FileStream(savePath, mode);
        }
        catch
        {
            Debug.Log(savePath + "Database couldn't be found or connected!");
            return false;
        }

        return true;
    }

    public Data FindDataByType(string type)
    {
        if (ConnectToDatabase(type, FileMode.Open))
        {
            throw new Exception("Database is not connected!");
        }

        var data = m_BinaryFormatter.Deserialize(m_Stream) as Data;
        DisconnectDatabase();
        return data;
    }

    public bool SaveData(Data data)
    {
        if (ConnectToDatabase(data.Type, FileMode.Create))
        {
            throw new Exception("Database is not connected!");
        }

        try
        {
            m_BinaryFormatter.Serialize(m_Stream, data);
        }
        catch
        {
            Debug.Log($"{data.Key} couldn't be serialized!");
            return false;
        }

        DisconnectDatabase();
        return true;
    }

    public void DisconnectDatabase()
    {
        m_Stream.Close();
    }
}