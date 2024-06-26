# Refinery
A simple C# program to automate the ringing of music bells in school

# A little bit of history
My mother is a teacher in the Механотехникум at Plovdiv (I do not care to translate it) and tasked me to make a program to automate their new "singing bells" that ring at the start and end at every lesson. I told her that I'm busy, so she tasked some lads from the school to make it. Unfortunately, these fellas didn't know what they were doing which led to the code being very unoptimized and unreadable. I tried to make a pull request with a couple of optimizations, but it looks like the repo has been abandoned with no recent commits or updates.

# How to run
- Place the executables in a folder you like.
- Create a `config` file in the folder.
- Add the variables in the file. The syntax is `<name> = <value>`. The variables needed are:

|    variable   |             example             |
|---------------|---------------------------------|
|port           |port = COM3                      |
|baud           |baud = 9600                      |
|bits           |bits = 0                         |
|start-audio    |start-audio = .\start.wav        |
|end-audio      |end-audio = .\end.wav            |
|emergency-audio|emergency-audio = .\emergency.wav|
|timetable      |timetable = .\timetable          |

- Create the timetable in a new file. The syntax is `HH:MM - HH:MM`. The times have to be ordered from the earliest to the latest.
