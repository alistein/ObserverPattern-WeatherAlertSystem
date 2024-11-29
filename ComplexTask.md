### Task: Real-Time Weather Monitoring System

#### Problem Description:

You are tasked to design a **Real-Time Weather Monitoring System**. The system will have multiple devices (observers) such as:

1. A **Smartphone App** that displays the current weather conditions.

2. A **Weather Dashboard** that shows weather trends.

3. An **Alert System** that sends notifications if severe weather conditions are detected (e.g., high wind speed, extreme temperatures).

The weather data will include:

+ Temperature (in °C)
+ Humidity (in %)
+ Wind Speed (in km/h)

The system should:

1. Allow devices to subscribe or unsubscribe from weather updates.

2. Notify all subscribed devices whenever the weather data changes.

3. Allow different observers to implement their own custom logic (e.g., sending alerts, visualizing trends).

#### Requirements:

1. Implement a Subject (e.g., WeatherStation) that tracks weather data.

2. Implement multiple Observers (e.g., SmartphoneApp, WeatherDashboard, AlertSystem).

3. Use real-time data updates (simulate them with random weather data or user input for now).
4. Add logic in the AlertSystem to trigger warnings for:
	+ Temperatures above 40°C or below 0°C.
	+ Wind speeds exceeding 100 km/h.


#### Bonus Features (Optional):

1. Implement a mechanism for observers to fetch historical data (e.g., track the last 5 updates).

2. Add priority-based notifications (e.g., AlertSystem gets notified before WeatherDashboard).