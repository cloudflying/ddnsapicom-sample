ddnsapi.com Sample Application
======================

### Version Details
**version 0.1** Initial Release  
Note: There is most likely typos and errors. If you see an error or typo, please add it to the github bug list.  


### What's Inside

**form1.vb**  
Main Application Window

**dnsUpdate.vb**  
Simulate an dynamic dns update. This normally occurs on your modem or router, but this tool allows you to force updates to the ddnsapi.com domain system.

**createDevice.vb**  
Demostrates how to create a new device via the ddnsapi.com api. Use the same procedure to update a device.

**findSingleDevice / findSingleDeviceByIP**  
Demostrates how to get a single device or a device list using the IP address.

**listDevicesAll.vb**  
Lists all the devices in your account.

**apiClasses Folder**  
All the classes used to talk with api.ddnsapi.com  


### Dependencies 

JSON.net - version 6.0.3+  
.net - version 4.0+