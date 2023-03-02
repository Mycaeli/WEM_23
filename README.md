# WEM_23

### Members 

* William Alejandro Pabon Guerrero/ID: 225366
* Miguel Calad Posada/ID: 350013               
* Emmanuel Echeverri Sepulveda/ID: 448007 


### Project Idea




### Vision

We are looking forward to do an interactive system that provide to our posible users an space where they can play with their sorrunding to experience rhytms and music.


### Interest




### Proto 1.0: 
We made an arduino system with a buzzer to use it like a piano, the mini piano works but the idea changed to use a Leap Motion, the code still works.

![Diagrama-Piano-Electrico-1024x463](https://user-images.githubusercontent.com/84156615/217916693-bf6f049f-c5fc-4a95-85df-6d70629816f7.png)
>Code.INO in the archives of the Git

-https://www.youtube.com/watch?v=hgfqUaslW6o-

### Avance 2.2:
We implement de Leap motion as a sensor to use in the experience of the music creation, the Leap Motion have some problems maping the hands in some position that we need but in general, its the perfect tool for the job, the next step its to build the interface in Unity to make it workfit at all, in this case to make a functional digital piano midi and the compass.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Leap%20Motion_test.png)

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Piano_test1.png)

### Proto 2.0:
The integration of the piano and the Leap motion was a hard step in the progress, the piano system have some errors because the leap motion have some trobbles trancking the hands and the piano just can play a Note one by one, if two notes are pushed at the same time the piano doesnt play anything, one solutions its to put a multi audio device in the unity, in theory all the piano sounds are in the same audio line so if we devide it, the sounds will play individualy, if that doesnt work, a code especifing the audio system outputs will be need it.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Leap%20Motion_test%20on%20piano.png)

### Avance 3.1:
The drums are in process of modeling, the base model its working with the sound effects, the ESP its in the final stages to be funtional and the Leap motion has some troubles with the fingers control and how the keys are pressed, the only way that the user can make 2 sounds at the same time its playing the piano upside ways because the hitbox of the hands are confusing the piano keys. The songs we´ll use are: Harry Potter Theme, Can U feel my heart, Lacrimosa, Rush E and Tetris Theme.

![image](https://github.com/Mycaeli/WEM_23/blob/main/Process/Drums_test1.png)

This is the reference for the piano system:
![image](https://user-images.githubusercontent.com/84156615/222506743-f4e86872-7ddd-40b1-96f2-1bb83fa07c9c.png)
