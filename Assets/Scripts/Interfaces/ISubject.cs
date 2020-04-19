
public interface ISubject
{
    /// <summary>
    /// Add observer into the observer list
    /// </summary>
    /// <param name="observer"></param>
    void AddObserver(IObserver observer);

    /// <summary>
    /// Remove observer from the observer list
    /// </summary>
    /// <param name="observer"></param>
    void RemoveObserver(IObserver observer);

    /// <summary>
    /// Notify every observer
    /// </summary>
    void Notify();
}
