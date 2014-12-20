#!/usr/bin/env node

var path = require('path'),
    util = require('util');

var keymap = {
    458960: 'G1',
    458961: 'G2',
    458962: 'G3',
    458963: 'G4',
    458964: 'G5',
    458965: 'G6',
    458966: 'G7',
    458967: 'G8',
    458968: 'G9',
    458969: 'G10',
    458970: 'G11',
    458971: 'G12',
    458972: 'G13',
    458973: 'G14',
    458974: 'G15',
    458975: 'G16',
    458984: 'G17',
    458985: 'G18'
};

var keycode = process.argv[2];

console.log(process.argv);

console.log('key pressed: ', keycode, keymap[keycode]);