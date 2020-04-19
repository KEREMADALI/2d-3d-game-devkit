using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class LocalDBHandler : IDatabaseHandler
{
    private BinaryFormatter m_BinaryFormatter;
    private FileStream m_Stream;

    public Data FindDataByType(string type)
    {
        if (!ConnectToDatabase(type, FileMode.OpenOrCreate, FileAccess.Read))
        {
            return null;
        }

        Data retVal = new Data(type);
        try
        {
            if (m_Stream.Length == 0)
            {
                // Stream is empty
                return null;
            }

            var rawData = m_BinaryFormatter.Deserialize(m_Stream);
            retVal = rawData as Data;
        }
        catch(Exception ex)
        {
            Debug.Log($"{type} couldn't be deserialized: {ex.Message}");
        }
        finally
        {
            DisconnectDatabase();
        }
        return retVal;
    }

    public bool SaveData(Data data)
    {
        if (!ConnectToDatabase(data.Type, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            throw new Exception("Database is not connected!");
        }

        try
        {
            m_BinaryFormatter.Serialize(m_Stream, data);
        }
        catch (Exception ex)
        {
            Debug.Log($"{data.Type} couldn't be serialized: {ex.Message}");
            return false;
        }
        finally
        {
            DisconnectDatabase();
        }
        
        return true;
    }

    public bool ConnectToDatabase(string type, FileMode mode, FileAccess fileAccess)
    {
        m_BinaryFormatter = new BinaryFormatter();
        string savePath = Application.persistentDataPath + $"/{type}.data";

        try
        {
            m_Stream = new FileStream(savePath, mode, fileAccess)
            {
                Position = 0
            };
        }
        catch(Exception exception)
        {
            Debug.Log($"{savePath} database does not exist! Exception: {exception}");
            return false;
        }

        return true;
    }

    public void DisconnectDatabase()
    {
        try
        {
            m_Stream.Flush();
            m_Stream.Close();
        }
        catch(Exception exception)
        {
            Debug.Log($"Database can not be closed.Exception: {exception.Message}");
        }
    }
}