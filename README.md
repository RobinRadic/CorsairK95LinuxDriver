Corsair Vengeance K95 Basic linux Driver Alpha
==================================================

Project is very alpha-ish. Use at own discretion

**State:** Currently writing a mono C# GUI for configuring G key actions (G1 to G18)

### Overview
- Uses C to get the scancode of the pressed or released key.
- getscancodes calls key2node.sh with the keycode as parameter
- key2node.sh executes index.js with nodejs


### How-to use
```bash
cd ~/
git clone https://github.com/RobinRadic/CorsairK95LinuxDriver corsairk95
cd corsairk95
make all
npm install
./getscancodes /dev/input/eventX
```






### getscancodes
Uses a modified version of [getscancodes](https://github.com/jupiter126/Linux_Custom_Control_Device) from Marvin Raaijmakers
BSD license applies to getscancodes.


### License
MIT license