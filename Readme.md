# Dns Flusher Service
This is a Windows Service that will execute the command ```ipconfig /flushdns``` every 3 hours.

## Installing the service
- Go to the release tab.
- Download the latest version.
- Open the command prompt as **administrator**
- ```cd``` to the location of where the DnsFlusher.exe is.
- Enter the command: ```"C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe" DnsFlusher.exe```.
- Service should be installed, to verify press ```cntr+R``` and enter ```services.msc```.
- Scroll down until you find ```DnsFlusher```.  

## Uninstall the service
Open command prompt and enter:
```sc delete DnsFlusher``` _(Need Administrator privileges for this)_