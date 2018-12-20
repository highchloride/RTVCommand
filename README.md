# RTVCommand
An open-source playout solution in C# for continuous, autonomous playback over 12 hour periods. Features a built in Media library, Playlist builder, and Scheduling panel that interfaces with Windows Task Scheduler.

## Goals
Provide myself a simple way to program an IPTV station with provided media.

### Current Functionality
It reads media into the library and contains some of the cleanest code I've ever written. Yippe for me. More to come.

### Process
RTVCommand will help to fill a 12-hour playlist designated as a day's AM or PM programming. This playlist is built from a media library also managed by the software. Once a playlist is constructed, the software can be used to engage Windows Task Scheduler to invoke your preferred Media Player and the Playlist during the 12-hour AM or PM block. 

### Features
RTVCommand views each playlist as a unit of 43,200 seconds and all media is considered in Seconds. When populating a Playlist, the software will attempt to fill the time up to the amount of seconds. Filters can be applied to the Media Library to allow for fast and easy selection of desire media programming. 

### Future
Probably serialize everything to XML or JSON instead of binary, but it works for now.
