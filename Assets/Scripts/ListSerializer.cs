﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class ListSerializer
{ 
    public static void Save(string filePath, object objToSerialize)
    {
        try
        {
            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, objToSerialize);
            }
        }
        catch (IOException)
        {
        }
    }

    public static T Load<T>(string filePath) where T : new()
    {
        T rez = new T();

        try
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                rez = (T) bin.Deserialize(stream);
            }
        }
        catch (IOException)
        {
        }

        return rez;
    }
}

