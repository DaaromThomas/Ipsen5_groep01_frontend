using Ipsen5_groep01_frontend.Interfaces;

namespace Ipsen5_groep01_frontend.Abstract_Classes{
    public abstract class Observable{
        private List<Observer> observers = new List<Observer>();

        public void subscribe(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void unsubscribe(Observer observer) 
        { 
            this.observers.Remove(observer);  
        }

        public void notifyObservers()
        {
            foreach (Observer observer in this.observers) 
            {
                observer.update();
            }
        }
    }
}