using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    /// <summary>
    /// Will be called by subject on notify
    /// </summary>
    /// <param name="subject"></param>
    void UpdateObserver(ISubject subject);
}
