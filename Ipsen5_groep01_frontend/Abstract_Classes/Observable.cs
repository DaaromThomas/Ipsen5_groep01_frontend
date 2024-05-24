using Ipsen5_groep01_frontend.Interfaces;

namespace Ipsen5_groep01_frontend.Abstract_Classes{
    public abstract class Observable{
        private List<Observer> observers = new List<Observer>();

        private void subscribe(Observer observer)
        {
            this.observers.Add(observer);
        }

        private void unsubscribe(Observer observer) 
        { 
            this.observers.Remove(observer);  
        }

        private void notifyObservers()
        {
            foreach (Observer observer in this.observers) 
            {
                observer.update();
            }
        }
    }
}