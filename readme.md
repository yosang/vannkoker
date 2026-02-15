# About
The "Vannkoker" is a Norwegian term for an electric kettle. Its a small kitchen appliance designed to quickly boil water using an internal heating element. It is used to prepare hot water for tea, coffee, hot meals etc.

The vannkoker boils water fast, in a matter of minutes, but compared to a microwave, it is not driven by a timer, but an internal metal heating element. When the internal heating element is turned, on it directly transfers heat to the water sitting on top of it.

As the water temperature rises, it starts to boil and produce steam. The way the vannkoker knows when to stop boiling is due to its steam sensor and thermostat.
- Steam rises and heats up the thermostat, when the thermostat gets hot enough it turns off the vannkoker.

# Implementation
We are going to send a smart vannkoker, that once it is done boiling water and turns off, sends of a push notification to our smart phone. This way we can start the vannkoker and get a notification on our phones that the water is ready.

- Publisher - The vannokoker class
    - Uses an `EventHandler` delegate
    - Has an event called `Done`
    - Has a method named `Start` that starts the vannoker with an internal logic for the temperature rising.
        - Once the temperature has risen to a high enough point, we are going to Invoke the `Done` event and notify all subscribers.
- Subscriber - The smartphone
    - Has a single method named `PushNotification`.
    - This method will be added to the Vannkoker `Done` event.

# Author
[Yosmel Chiang](https://github.com/yosang)
