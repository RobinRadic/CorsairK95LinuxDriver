# Corsair Vengeance K95 Basic *nix Driver Alpha
==================================

Project is very alpha-ish. Use at own discretion
Based on [LCCD]https://github.com/jupiter126/Linux_Custom_Control_Device

## BSD license

By using this program, you agree to all of the following
- getscancodes is published under GPL V2 (Like Marvin Raaijmakers' original source).  
- It is released under BSD licence
- I assume no responsabilities whatsoever for the consequences of running this program on your computer, it runs on mine, I share it, and it is your sole reponsability to use it.

## How-to use

TBA


## Dependancies

  - To simulate keypresses, use either xmacro or xsendkeycodes, depending on your distribution.
  
User Communication is done trough libnotify and also depends on x11-apps/xhost
  - gentoo x11-libs/libnotify x11-apps/xhost
  - debian/*buntu libnotify-bin
  - redhat/fedora/centos libnotify
  - Windows, it was a pleasure, have a nice day!

make and GCC are required to compile getscancodes
The rest of the dependencies depend of your scripts.

This script heavily relies on a slightly modified version of getscancodes (original code by Marvin Raaijmakers).
"getscancodes", by Marvin Raaijmakers is available at http://keytouch.sourceforge.net/dl-getscancodes.html
However, the actual code of getscancodes does not allow for redirection, it needed the following change (Credits to Badger for finding the bug, and to Kon for fixing it): 
at line 92 of scancodes.c, replace 
	printf("%d (0x%x)\n", ev[i].value, ev[i].value);
with
	char buf[8]; sprintf(buf, "%d\n", ev[i].value); write(1, buf, sizeof(buf)); fsync(1);
This change is allready applied to the source I hereby provide, it allows to redirect it's output (changed the way it buffers), thus to collect the scancodes in a text file.

## Changelog
-----------------------------------------------
	0.1 --> - initial version
## Todo 


## Bugs 
- A lot