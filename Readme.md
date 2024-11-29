### Observer Pattern

> The Observer Pattern is a behavioral design pattern used to establish a one-to-many dependency between objects. When one object (the subject) changes its state, all its dependent objects (the observers) are notified and updated automatically.

Key components:

1.	**Subject**: The object that maintains a list of its observers and notifies them of any state changes.

2.	**Observer**: The object that subscribes to the subject's updates. It defines a method to update itself when notified. 

3. **Concrete Subject**: A specific implementation of the subject that stores the state and notifies observers of changes.

4. **Concrete Observer**: A specific implementation of the observer that reacts to updates from the subject.

