
[https://embeddedartistry.com](https://embeddedartistry.com/) 

# Entry level embedded software career guide

[

Employment-education

](https://www.reddit.com/r/embedded/?f=flair_name%3A%22Employment-education%22)

# Entry Level Embedded Software Career Guide

I frequently get asked for advice on getting into embedded internships and entry level, so I decided to put together a simple guide based on my experience. Feel free to add your advice or perspective. Note that this is an embedded _software_ guide. There are many embedded systems jobs out there beyond software; this isn't the only path.

**Disclaimer:** This guide is based on my anecdotal, subjective experience. I'm a primarily self-taught embedded software / firmware engineer, living in the Bay Area, 1.5 YOE, with two embedded systems internships, and 1 full time firmware position, currently looking for my 2nd position, and currently interviewing with the high compensation companies. I decided to make this career change 2 years ago, with no prior software or technical degree or experience. What worked for me, may not work for you. I highly encourage you to continuously refine redirect your path based on your own research through talking with working engineers, looking at job postings, and reading articles.

## Rule # 1: Build and show off skills that are in-demand by employers.

This is the advice I give to anyone looking for a job in any industry.

What are the skills that are in-demand? This is highly dependent on the area you live in, and the industries around you. Go to LinkedIn / Google / Indeed, and look at all the entry level and internship job postings for embedded software / firmware, and tabulate skills that are asked for. This doesn't need to be rigorous, and there will probably be a bunch of terms and concepts that you don't know -- that's okay. For now, just focus on the common concepts.

My list ended up looking something like this:

- C
    
- C++
    
- Testing
    
- RTOS
    
- Board bring-up
    
- Driver development
    
- I2C
    
- Sensors & Actuators
    
- ARM
    
- Linux Kernel Development
    
- Python
    
- Microcontrollers
    
- UART
    
- Bluetooth / Wifi / IEEE 802.11
    
- System Debug
    
- OS Architecture / Design
    
- ...
    

One thing to also notice is common clusterings of skills: microcontrollers, embedded linux, hardware testing, networking, automotive, and IoT are the common ones I've seen in my search.

Personally, I focused on the most in-demand, broadest, and fundamental skills first, because I wanted a job, and I wanted the ability to pivot to different types of development if I ended up disliking a subfield.

## Fundamentals

The following topics / courses will give you a strong foundation for embedded systems software development, and questions about the basics will likely come up in interviews:

1. **Introduction to Programming.** [CS50](https://www.edx.org/course/cs50s-introduction-to-computer-science) is a great first course. Covers a lot, but has a ton of auxiliary resources.
    
2. **Data Structures and Algorithms.** There's tons of resources out there already, so I won't go into that here.
    
3. **Computer Organization / Systems.** (Learn the basic hardware in a computer, and learn assembly)
    
4. **Operating Systems.** The combination of a good computer organization and assembly course, with a good operating systems course answered so many questions for me and filled in a ton of blanks.
    

## How do I build these skills?

1. A computer engineering, electrical engineering, or computer science degree, with a selection of electives focused on embedded software concepts will get you 75% of the way to a job, and will make it significantly easier for you to get interviews.
    
2. [Embedded Systems Rule the World](http://users.ece.utexas.edu/~valvano/Volume1/E-Book/), and [Real-Time Bluetooth Networks - Shape the World](https://www.edx.org/course/real-time-bluetooth-networks-shape-the-world) will get you good enough projects to land a job if you complete them, and if you can intelligently talk about the covered topics. Whether you're self-taught, or getting a degree, I 100% recommend working through these two courses as a first step towards getting employable, real world skills. (If you're completely new to programming, complete CS50 first).
    
3. Learn to Google! There are so many resources out there, at all levels, to help with your learning. Each concept that you need to learn, you need to understand why people use it, alternatives, what problem it solves, and ways to implement it. Find tutorials that work for you -- for some concepts, I've had to go through multiple textbooks and multiple tutorials before they finally clicked. Be a relentless autodidact.
    

### Specific Resources

|Concept|Resources|
|---|---|
|C|[K&R](https://en.wikipedia.org/wiki/The_C_Programming_Language), the canonical C handbook, and a relatively quick read. ["Modern C" by Gustedt](http://icube-icps.unistra.fr/index.php/File:ModernC.pdf) for a more in depth, and modern, take.|
|Testing|"Test Driven Development for Embedded C" by Grenning|
|Operating Systems|"Operating Systems" by Silberschatz. ["Operating Systems: Three Easy Pieces" by Arpaci-Dusseau](http://pages.cs.wisc.edu/~remzi/OSTEP/)|
|RTOS|A good operating systems textbook will be a great starting point. Checkout this [FreeRTOS Tutorial](https://www.freertos.org/tutorial/), and I've also heard good things about the "Modern Embedded Systems Programming" YouTube channel. [Real-Time Bluetooth Networks - Shape the World](https://www.edx.org/course/real-time-bluetooth-networks-shape-the-world)|
|I2C, UART, SPI|There are great articles on [Sparkfun](https://learn.sparkfun.com/tutorials/serial-communication/all) and [Adafruit](https://learn.adafruit.com/circuit-playground-express-serial-communications/what-is-serial-communications).|
|Sensors & Actuators|The [Robogrok](http://www.robogrok.com/) robotics course Youtube videos have a great, newbie friendly introduction to robotics, sensors, actuators, and PID control.|
|Linux Kernel Development|I frequently see "Linux Kernel Development" by Love as recommended|
|Microcontrollers|[Embedded Systems Rule the World](http://users.ece.utexas.edu/~valvano/Volume1/E-Book/)|
|Bluetooth / Wifi / IEEE 802.11|[Real-Time Bluetooth Networks - Shape the World](https://www.edx.org/course/real-time-bluetooth-networks-shape-the-world)|

**Other General Resources I've found helpful:**

The "Making Embedded Systems" book by Elecia White ([u/logicalelegance](https://www.reddit.com/user/logicalelegance/)) -- a great introduction to the basics of embedded systems, and does a good job of being an easy read for newbies.

[Embedded.fm Podcast](https://embedded.fm/). Great podcast hosted by the above author.

[Embedded Artistry](https://embeddedartistry.com/). Good articles.

[The Ganssle Group](http://www.ganssle.com/). Good articles.

[Barr Group](https://barrgroup.com/). Good articles.

[The Amp Hour](https://theamphour.com/). Hardware focused podcast.

[Adafruit](https://learn.adafruit.com/). The 'working out of the box' hardware paired with newbie friendly tutorials are a nice starting point. Professional development kits and datasheets are oriented towards people who've already worked on similar systems, so there is quite a bit of assumed context someone new to the field doesn't have.

## Applications

The best way to get your application moved forward is through personal connections, and recommendations. But, sometimes that isn't an option, and you have to cold apply.

My advice is to apply to positions that you meet >=50% of the requirements.

Make sure you get you resume reviewed by professionals in the field before applying.

If you get a low response rate, you need to get your resume re-reviewed, or you need to build better projects that better demonstrate the skills employers are looking for.

## Interview Questions

In addition to typical software interview preparation, embedded software interviews tend to ask some repetitive questions. I don't know how many times I've answered what volatile and static are. Here are some typical questions:

- What is static?
    
- What is volatile?
    
- How does an interrupt work?
    
- What programming practices should typically be avoided in embedded systems, and why?
    
- Basic circuits questions: Ohms law. Voltage Dividers. Series and Parallel Resistors.
    
- Compare and contrast I2C, UART, and SPI
    
- How does an ADC work? How about a DAC?
    
- Compare and contrast Mutex and Semaphores
    
- Linked List algorithm questions
    
- String manipulation algorithm questions
    
- Bit manipulation algorithm questions
    
- Tell me about a hardware issue you debugged.
    
- Why would you use an RTOS?
    
- How does an OS manage memory?

## digital signal processing 

Exercise
https://exercism.org/

https://medium.com/@light-city/35k-star-stories-about-c-plus-plus-step-by-step-learning-c8cd51b5a75 

## dsp
https://www.reddit.com/r/diypedals/s/P9ufBm8uF5
I would recommend an electrosmith daisy. They have a built in analog/ digital converter. It also has a built in library with delay lines and other usable methods. It is coded in c or c++. Hope this helps, let me know if you need any more information.
https://www.reddit.com/r/DSP/s/443tIkDdcK
https://www.reddit.com/r/DSP/s/rkzzS6rcgY
https://dsp.stackexchange.com/questions/29225/recommendation-for-book-writing-dsp-code-in-c

https://www.reddit.com/r/embedded/s/EWTO1SuqSK 
Embeded adio 
https://www.reddit.com/r/embedded/s/pn9S2E1cKF

https://www.reddit.com/r/DSP/s/01MV87WQKz 




